using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace IpAutoEditor
{
    class TestSet
    {
        private delegate void MasterStart();
        private Hashtable info = new Hashtable();
        private Thread inspection ;
        private Form1 f1 = null;
        public TestSet(Form1 f1)
        {
            this.f1 = f1;
            this.inspection = new Thread(new ThreadStart(Inspection));
        }

        private void form1start()
        {
            if (f1.InvokeRequired)
            {
                MasterStart ms = new MasterStart(form1start);
                f1.Invoke(ms);
            }
            else
            {
                f1.Start();
            }
        }

        //启动守护进程
        public void Start()
        {
            f1.setStatusT("守护功能已经启动");
            this.inspection.Start();
        }

        public void Inspection()
        {
            while(true){
                if (!Cmd.ping(Form1.ipinfo["Gateway"].ToString(),Form1.ipinfo["DNS"].ToString()))
                {
                    this.form1start();
                    break;
                }
                Thread.Sleep(3000);
            }
            this.inspection.Abort();
        }
        //关闭守护进程
        public void Close()
        {
            this.inspection.Abort();
        }
    }
}
