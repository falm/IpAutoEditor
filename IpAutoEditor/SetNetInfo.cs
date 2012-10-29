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
    public partial class SetNetInfo : Form
    {
        public Hashtable ipinfo = new Hashtable();
        public SetNetInfo(Hashtable ipinfo)
        {
            InitializeComponent();
            this.ipinfo = ipinfo;
        }

        private void SetNetInfo_Load(object sender, EventArgs e)
        {
            this.Netmask_Text.Text = this.ipinfo["Netmask"].ToString();
            this.Gateway_Text.Text = this.ipinfo["Gateway"].ToString();
            this.Dns_Text.Text = this.ipinfo["DNS"].ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            this.ipinfo["Netmask"] = this.Netmask_Text.Text;
            this.ipinfo["Gateway"] = this.Gateway_Text.Text;
            this.ipinfo["DNS"]=this.Dns_Text.Text;
            this.Close();
        }
    }
}
