namespace WeiBo_DIY
{
    partial class ClientLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAppKey = new System.Windows.Forms.TextBox();
            this.txtAppSecret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCallbackURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "AppKey";
            // 
            // txtAppKey
            // 
            this.txtAppKey.Enabled = false;
            this.txtAppKey.Location = new System.Drawing.Point(138, 32);
            this.txtAppKey.Name = "txtAppKey";
            this.txtAppKey.Size = new System.Drawing.Size(138, 21);
            this.txtAppKey.TabIndex = 1;
            this.txtAppKey.Text = "1019353186";
            // 
            // txtAppSecret
            // 
            this.txtAppSecret.Enabled = false;
            this.txtAppSecret.Location = new System.Drawing.Point(138, 81);
            this.txtAppSecret.Name = "txtAppSecret";
            this.txtAppSecret.Size = new System.Drawing.Size(138, 21);
            this.txtAppSecret.TabIndex = 3;
            this.txtAppSecret.Text = "aac1b5fa248c0238b63e8ff9b29944a7";
            this.txtAppSecret.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "AppSecret";
            // 
            // txtCallbackURL
            // 
            this.txtCallbackURL.Enabled = false;
            this.txtCallbackURL.Location = new System.Drawing.Point(138, 132);
            this.txtCallbackURL.Name = "txtCallbackURL";
            this.txtCallbackURL.Size = new System.Drawing.Size(138, 21);
            this.txtCallbackURL.TabIndex = 5;
            this.txtCallbackURL.Text = "http://weibo.com/u/2107228872";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "回调地址";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(138, 185);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(138, 21);
            this.txtPassport.TabIndex = 7;
            this.txtPassport.Text = "964968324@qq.com";
            this.txtPassport.TextChanged += new System.EventHandler(this.txtPassport_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "账户";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(138, 242);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(138, 21);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "254634";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "密码";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(53, 301);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 26);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 26);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ClientLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 358);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCallbackURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAppSecret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAppKey);
            this.Controls.Add(this.label1);
            this.Name = "ClientLoginForm";
            this.Text = "账户登录窗体";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        protected internal System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtAppKey;
        private System.Windows.Forms.TextBox txtAppSecret;
        private System.Windows.Forms.TextBox txtCallbackURL;
        private System.Windows.Forms.TextBox txtPassword;
        protected internal System.Windows.Forms.TextBox txtPassport;
    }
}