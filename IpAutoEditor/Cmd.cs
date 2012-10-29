using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace IpAutoEditor
{
    class Cmd
    {
        public static string startcmd(string command)

        {

            string output = "";

            try

            {



                Process cmd = new Process();

                cmd.StartInfo.FileName = "cmd.exe";

 

                cmd.StartInfo.UseShellExecute = false;

 

                cmd.StartInfo.RedirectStandardInput = true;

                cmd.StartInfo.RedirectStandardOutput = true;

                cmd.StartInfo.CreateNoWindow = true;

                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

 

                cmd.Start();

 

                output = cmd.StandardOutput.ReadToEnd();

                Console.WriteLine(output);

                cmd.WaitForExit();

                cmd.Close();

            }

            catch (Exception e)

            {

                Console.WriteLine(e);

            }

            return output;

        }

        public static string startcmd(string command, string argument)

        {

            string output = "";

            try

            {

                Process cmd = new Process();

 

                cmd.StartInfo.FileName = command;

                cmd.StartInfo.Arguments = argument;

 

                cmd.StartInfo.UseShellExecute = false;

 

                cmd.StartInfo.RedirectStandardInput = true;

                cmd.StartInfo.RedirectStandardOutput = true;

 

                cmd.StartInfo.CreateNoWindow = true;

                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

 

                cmd.Start();



                output = cmd.StandardOutput.ReadToEnd();

                Console.WriteLine(output);

                cmd.WaitForExit();

                cmd.Close();

            }

            catch (Exception e)

            {

                Console.WriteLine(e);

            }

            return output;
        }
        public static string comd(string[] cmd)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.AutoFlush = true;
            for (int i = 0; i < cmd.Length; i++)
            {
                p.StandardInput.WriteLine(cmd[i].ToString());
            }
            p.StandardInput.WriteLine("exit");
            string strRst = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
            return strRst;
        }

        // Ping 命令方法
        public static bool ping(string strip)
        {
            Ping myping = new Ping();
            PingOptions myoptions = new PingOptions();

            myoptions.DontFragment = true;//允许数据分段,还有一个ttl选项

            //创建一个32b的缓冲区

            string data = "abcdefghijklmnopqrstuvwxy123456";

            byte[] buff = Encoding.ASCII.GetBytes(data);
            PingReply mypingreply = myping.Send(strip, 500, buff, myoptions);
            if (mypingreply.Status == IPStatus.Success)
            {

                return true;

            }
            else return false;

        }

        // Ping 命令方法2
        public static bool ping(string strip, string strip2)
        {
            Ping myping = new Ping();
            PingOptions myoptions = new PingOptions();

            myoptions.DontFragment = true;//允许数据分段,还有一个ttl选项

            //创建一个32b的缓冲区

            string data = "abcdefghijklmnopqrstuvwxy123456";

            byte[] buff = Encoding.ASCII.GetBytes(data);
            PingReply mypingreply = myping.Send(strip, 500, buff, myoptions);
            PingReply mypingreply2 = myping.Send(strip2, 500, buff, myoptions);
            if ((mypingreply.Status == IPStatus.Success) && (mypingreply2.Status == IPStatus.Success))
            {

                return true;

            }
            else return false;

        }

        /// <summary>
        /// 关闭进程
        /// </summary>
        /// <param name="ProcName">进程名称</param>
        /// <returns></returns>
        public static bool CloseProcess(string ProcName)
        {
            bool result = false;
            System.Collections.ArrayList procList = new System.Collections.ArrayList();
            string tempName = "";
            int begpos;
            int endpos;
            foreach (System.Diagnostics.Process thisProc in System.Diagnostics.Process.GetProcesses())
            {
                tempName = thisProc.ToString();
                begpos = tempName.IndexOf("(") + 1;
                endpos = tempName.IndexOf(")");
                tempName = tempName.Substring(begpos, endpos - begpos);
                procList.Add(tempName);
                if (tempName == ProcName)
                {
                    if (!thisProc.CloseMainWindow())
                        thisProc.Kill(); // 当发送关闭窗口命令无效时强行结束进程
                    result = true;
                }
            }
            return result;
        }

    }
}
