namespace IpAutoEditor
{
    partial class SetNetInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.Netmask_Text = new System.Windows.Forms.TextBox();
            this.Gateway_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dns_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(66, 100);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 0;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(163, 100);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Netmask_Text
            // 
            this.Netmask_Text.Location = new System.Drawing.Point(66, 12);
            this.Netmask_Text.Name = "Netmask_Text";
            this.Netmask_Text.Size = new System.Drawing.Size(172, 21);
            this.Netmask_Text.TabIndex = 2;
            // 
            // Gateway_Text
            // 
            this.Gateway_Text.Location = new System.Drawing.Point(66, 39);
            this.Gateway_Text.Name = "Gateway_Text";
            this.Gateway_Text.Size = new System.Drawing.Size(172, 21);
            this.Gateway_Text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Netmask:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gateway:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "DNS:";
            // 
            // Dns_Text
            // 
            this.Dns_Text.Location = new System.Drawing.Point(66, 66);
            this.Dns_Text.Name = "Dns_Text";
            this.Dns_Text.Size = new System.Drawing.Size(172, 21);
            this.Dns_Text.TabIndex = 3;
            // 
            // SetNetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 135);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gateway_Text);
            this.Controls.Add(this.Dns_Text);
            this.Controls.Add(this.Netmask_Text);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Name = "SetNetInfo";
            this.Text = "SetNetInfo";
            this.Load += new System.EventHandler(this.SetNetInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox Netmask_Text;
        private System.Windows.Forms.TextBox Gateway_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Dns_Text;
    }
}