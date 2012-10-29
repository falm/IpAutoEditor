namespace IpAutoEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.status_text = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动守护功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置网关和DNSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += new System.EventHandler(this.setStatusText);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "59.73.116.0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 21);
            this.textBox2.TabIndex = 1;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(101, 190);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "起始地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "结束地址";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 150);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "进度:";
            this.label4.Visible = false;
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(208, 190);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(64, 23);
            this.pause.TabIndex = 8;
            this.pause.Text = "暂停";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Visible = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(207, 220);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(64, 23);
            this.stop.TabIndex = 9;
            this.stop.Text = "停止";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(10, 231);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(35, 12);
            this.status_label.TabIndex = 10;
            this.status_label.Text = "状态:";
            this.status_label.Visible = false;
            // 
            // status_text
            // 
            this.status_text.AutoSize = true;
            this.status_text.Location = new System.Drawing.Point(45, 231);
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(11, 12);
            this.status_text.TabIndex = 11;
            this.status_text.Text = "1";
            this.status_text.Visible = false;
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(197, 226);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 12;
            this.finish.Text = "完成";
            this.finish.UseVisualStyleBackColor = false;
            this.finish.Visible = false;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settinToolStripMenuItem
            // 
            this.settinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动守护功能ToolStripMenuItem,
            this.设置网关和DNSToolStripMenuItem});
            this.settinToolStripMenuItem.Name = "settinToolStripMenuItem";
            this.settinToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.settinToolStripMenuItem.Text = "设置";
            
            // 
            // 启动守护功能ToolStripMenuItem
            // 
            this.启动守护功能ToolStripMenuItem.Name = "启动守护功能ToolStripMenuItem";
            this.启动守护功能ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.启动守护功能ToolStripMenuItem.Text = "启动守护功能";
            this.启动守护功能ToolStripMenuItem.Click += new System.EventHandler(this.启动守护功能ToolStripMenuItem_Click);
            // 
            // 设置网关和DNSToolStripMenuItem
            // 
            this.设置网关和DNSToolStripMenuItem.Name = "设置网关和DNSToolStripMenuItem";
            this.设置网关和DNSToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.设置网关和DNSToolStripMenuItem.Text = "设置网关和子网掩码";
            this.设置网关和DNSToolStripMenuItem.Click += new System.EventHandler(this.设置网关和DNSToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.status_text);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ip自动修改器(Beta)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label status_text;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动守护功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置网关和DNSToolStripMenuItem;
    }
}

