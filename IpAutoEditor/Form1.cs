using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Threading;

namespace IpAutoEditor
{
    public partial class Form1 : Form
    {

        private delegate void SetPos(int ipos);         //设置进度条的委托
        public delegate void setStatus(string text);    //设置状态信息的委托

        private Thread tthread;             //进度条线程
        private Thread sthread;             //设置IP主线程
        private static int s_i = 0;         //IP起始位
        private static int s_len = 0;       //IP终止位
        private static bool flag = true;    // 标志变量
        private static string status = "";
        private static bool success = false;
        public static Hashtable ipinfo = new Hashtable();   // 网关 DNS 子网掩码 哈希表

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.loads();
            this.sthread= new Thread(new ThreadStart(procS));
            this.tthread = new Thread(new ThreadStart(procT));
            // 网关 DNS 子网掩码 默认值
            ipinfo.Add("DNS", "202.199.240.16");           
            ipinfo.Add("Gateway", "59.73.116.254");
            ipinfo.Add("Netmask", "255.255.255.0");

        }

        //设置进度条信息
        private  void SetTextMessage(int ipos)
        {
            if (this.InvokeRequired)
            {
                SetPos setpos = new SetPos(SetTextMessage);
                this.Invoke(setpos, new object[] { ipos });
             //   this.Invoke(
            }
            else
            {
                this.label3.Text = ipos.ToString() + "/100";
                this.progressBar1.Value = Convert.ToInt32(ipos);
            }
        }





        //开始按钮 Click事件
        private void start_Click(object sender, EventArgs e)
        {
            this.Start();

        }
        // 启动主进程
        public void Start()
        {
            //this.procS();
            //this.fthread.Start(new object[] { i, endI });
            label4.Visible = true;
            label3.Visible = true;
            progressBar1.Visible = true;
            this.sthread.Start();
            pause.Visible = true;
            stop.Visible = true;
            status_label.Visible = true;
            status_text.Visible = true;
            start.Visible = false;
            //this.setStatusText();
        }
        // 进度条 线程方法
        private void procT()
        {
            while (true)
            {
                this.SetTextMessage(100 * s_i / s_len);
               // Thread.Sleep(7000);
            }
        }
        // IP editor 主线程方法
        private  void procS()
        {
            string start = textBox1.Text;
            string end = textBox2.Text;
            //Array mask = new string[]{"255.255.255.0", "255.255.255.0"};
            //Array gate = new string[] {"59.73.116.254","59.73.116.254"};
            
            string[] key1 = start.Split('.');
            string[] key2 = end.Split('.');
            bool flag = false;
            int startI = Convert.ToInt32(key1[3]);
            int endI = Convert.ToInt32(key2[3]);
            s_len = endI;
            
           
            this.tthread.Start();
            for(int i= startI ; i<= endI;i++){

                string ip = key1[0] + "." + key1[1] + "." + key1[2] + "." + i.ToString();
                // Array ipa = new string[]{ ip,ip };
                //this.setNetworkAdapter(ipa,mask,gate);
                //status = "正在尝试IP：" + ip;
                this.setStatusT("正在尝试IP：" + ip);
               
                try
                {
                    s_i = i;


                    string[] cmd = new string[] { "netsh interface ip set address name=\"本地连接\" source=static addr=" + ip + " mask=" + ipinfo["Netmask"].ToString() + "gateway=" + ipinfo["Gateway"].ToString() + " gwmetric=1" };
                    string res = Cmd.comd(cmd);
                    Thread.Sleep(4000);

                    //this.SetTextMessage(100 * i / endI);
                    if (Cmd.ping( ipinfo["Gateway"].ToString() , ipinfo["DNS"].ToString() ))
                    {
                        MessageBox.Show(res);
                        Cmd.CloseProcess("cmd.exe");
                        this.tthread.Abort();
                        success = true;
                        
                        break;

                    }
                    
                }catch(Exception e)
                {
                    //MessageBox.Show(e.Message+"， 正在尝试下一个IP地址！");
                    //status = e.Message + "， 正在尝试下一个IP地址！";
                    this.setStatusT(e.Message + "， 正在尝试下一个IP地址！");
                    continue;
                }
            }
            MessageBox.Show("IP:"+ s_i.ToString());
            if (!success)
            {
                //status = "IP设置失败!";
                this.setStatusT("IP设置失败!");
                MessageBox.Show("IP设置失败！");

            }
            else
            {
                //status = "IP地址设置成功!";
                this.setStatusT("IP地址设置成功!");
                MessageBox.Show("IP设置成功！");
            }
            
            //this.tthread.Abort();
            //this.sthread.Abort();
            this.tthread.Join();
            this.sthread.Join();
        }



        //暂停按钮 Click事件
        private void pause_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                this.sthread.Suspend();
                this.tthread.Suspend();
                pause.Text = "继续";
                status_text.Text = "已暂停";
                flag = !flag;
            }
            else
            {
                this.sthread.Resume();
                this.tthread.Resume();
                pause.Text = "暂停";
                flag = !flag;
            }
        }
        //停止按钮 Click事件
        private void stop_Click(object sender, EventArgs e)
        {
            flag = false;
            this.tthread.Abort();
            this.sthread.Abort();
            status_text.Text = "已停止";
            
            
        }

        //设置 状态信息
        public void setStatusText(object sender, EventArgs e)
        {
            if(flag)
            {
                status_text.Text = status;
                if (success) {
                    this.Success();
                }
            }
        }
        //设置 状态信息
        public void setStatusT(string text)
        {
            if (status_text.InvokeRequired)
            {
                setStatus setS = new setStatus(setStatusT);
                this.Invoke(setS,new object[]{ text });
            }
            else
            {
                status_text.Text = text;
                if (success)
                {
                    this.Success();
                }
            }
        }
        // 完成后执行方法
        public void Success()
        {
            this.stop.Visible = false;
            this.pause.Visible = false;
            this.progressBar1.Visible=false;
            this.label3.Visible = false;
            this.label4.Visible = false;

            this.finish.Visible = true;
            status_text.Text = "设置成功";

        }
        //完成按钮 Click事件
        private void finish_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }


        private void 设置网关和DNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNetInfo sni = new SetNetInfo(ipinfo);
            sni.ShowDialog();
            ipinfo = sni.ipinfo;
        }

        private void 启动守护功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TestSet  ts = new TestSet(this);
            ts.Start();
            this.启动守护功能ToolStripMenuItem.Text = "关闭守护功能";
        }




    }
}
