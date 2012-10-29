using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Permissions;
using System.Management;
using System.Net.NetworkInformation;
using Microsoft.Win32;

namespace IpAutoEditor
{
    class laIP
    {
        private void loads()
        {
            /*
                        try
                        {
                            RegistryKey reg = Registry.LocalMachine.OpenSubKey(@"System\CurrentControlSet\Services\Tcpip\Linkage");
                            string[] str = (String[])reg.GetValue("Route");
                            strnew = str[0].Substring(1, str[0].Length - 2);
                            string path = @"System\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\" + strnew;
                            RegistryKey regIp = Registry.LocalMachine.OpenSubKey(path);
                            string[] strIP = (String[])regIp.GetValue("IPAddress", "Null", RegistryValueOptions.None);
                            this.textBox1.Text = strIP[0];
                        }
                        catch (Exception ey)
                        {
                            MessageBox.Show(ey.Message);
                        }

                    }
                    private bool setNetworkAdapter(Array ipadd, Array mask, Array gate)
                    {
                        ManagementBaseObject inPar = null;
                        ManagementBaseObject outPar = null;
                        ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                        ManagementObjectCollection moc = mc.GetInstances();
                        foreach (ManagementObject mo in moc)
                        {
                            if (!(bool)mo["IPEnabled"])
                                continue;
                            // MessageBox.Show(mo["IPEnabled"].ToString());
                            //设置ip地址和子网掩码 
                            inPar = mo.GetMethodParameters("EnableStatic");
                            inPar["IPAddress"] = ipadd;//new string[] { "192.168.16.248", "192.168.16.249" };// 1.备用 2.IP
                            inPar["SubnetMask"] = mask;//new string[] { "255.255.255.0", "255.255.255.0" };
                            outPar = mo.InvokeMethod("EnableStatic", inPar, null);

                            //设置网关地址 
                            inPar = mo.GetMethodParameters("SetGateways");
                            inPar["DefaultIPGateway"] = gate;//new string[] { "192.168.16.2", "192.168.16.254" }; // 1.网关;2.备用网关
                            outPar = mo.InvokeMethod("SetGateways", inPar, null);

                            break;
                        }
                        return true;
                    }
                    private bool setIp(string ip)
                    {
                        string[] str = new string[1];
                        str[0] = ip;
                        string path = @"System\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\" + strnew;
                        Registry.LocalMachine.CreateSubKey(path).SetValue("IPAddress", str, RegistryValueKind.MultiString);


                        //MessageBox.Show("修改成功--请重新启动计算机");
                        return true;
                    }
             */
        }
    }
}
