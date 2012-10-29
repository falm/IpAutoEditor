using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IpAutoEditor
{
    public partial class test : Form
    {
        public static Hashtable ipinfo = new Hashtable();
        
        public test()
        {
            InitializeComponent();
            ipinfo.Add("DNS","202.199.240.16");
            ipinfo.Add("Gateway","59.73.116.254");
            ipinfo.Add("Netmask","255.255.255.0");
        }

        private void 设置网关和DNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNetInfo sni = new SetNetInfo(ipinfo);
            sni.ShowDialog();
            ipinfo = sni.ipinfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(DictionaryEntry info in ipinfo){
                MessageBox.Show(info.Key.ToString() + " : "+info.Value.ToString()); 
            }
        }

        public void setMsg()
        {

        }
    }
}
