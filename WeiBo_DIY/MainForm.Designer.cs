namespace WeiBo_DIY
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发布ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.获取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.ControlsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.clientLoginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loginToolStripMenuItem.Text = "登录（&L）";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // clientLoginToolStripMenuItem
            // 
            this.clientLoginToolStripMenuItem.Name = "clientLoginToolStripMenuItem";
            this.clientLoginToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clientLoginToolStripMenuItem.Text = "账户登录（&C）";
            this.clientLoginToolStripMenuItem.Click += new System.EventHandler(this.clientLoginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "退出（&E）";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.调用ToolStripMenuItem,
            this.发布ToolStripMenuItem,
            this.获取ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 调用ToolStripMenuItem
            // 
            this.调用ToolStripMenuItem.Name = "调用ToolStripMenuItem";
            this.调用ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.调用ToolStripMenuItem.Text = "调用";
            this.调用ToolStripMenuItem.Click += new System.EventHandler(this.调用ToolStripMenuItem_Click);
            // 
            // 发布ToolStripMenuItem
            // 
            this.发布ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文字ToolStripMenuItem,
            this.图片ToolStripMenuItem});
            this.发布ToolStripMenuItem.Name = "发布ToolStripMenuItem";
            this.发布ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.发布ToolStripMenuItem.Text = "发布";
            // 
            // 文字ToolStripMenuItem
            // 
            this.文字ToolStripMenuItem.Name = "文字ToolStripMenuItem";
            this.文字ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.文字ToolStripMenuItem.Text = "文字";
            this.文字ToolStripMenuItem.Click += new System.EventHandler(this.文字ToolStripMenuItem_Click);
            // 
            // 图片ToolStripMenuItem
            // 
            this.图片ToolStripMenuItem.Name = "图片ToolStripMenuItem";
            this.图片ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.图片ToolStripMenuItem.Text = "图片";
            this.图片ToolStripMenuItem.Click += new System.EventHandler(this.图片ToolStripMenuItem_Click);
            // 
            // 获取ToolStripMenuItem
            // 
            this.获取ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.获取ToolStripMenuItem.Name = "获取ToolStripMenuItem";
            this.获取ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.获取ToolStripMenuItem.Text = "获取最近（？）条微博";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "输入整数后按空格键获取";
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            this.toolStripTextBox1.MouseEnter += new System.EventHandler(this.toolStripTextBox1_MouseEnter);
            // 
            // lstMessage
            // 
            this.lstMessage.BackColor = System.Drawing.Color.White;
            this.lstMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstMessage.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstMessage.FormattingEnabled = true;
            this.lstMessage.HorizontalScrollbar = true;
            this.lstMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstMessage.ItemHeight = 14;
            this.lstMessage.Items.AddRange(new object[] {
            "欢迎使用微博_DIY客户端！"});
            this.lstMessage.Location = new System.Drawing.Point(0, 25);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstMessage.Size = new System.Drawing.Size(205, 389);
            this.lstMessage.TabIndex = 1;
            // 
            // ControlsContainer
            // 
            this.ControlsContainer.AutoScroll = true;
            this.ControlsContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ControlsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsContainer.Location = new System.Drawing.Point(205, 25);
            this.ControlsContainer.Name = "ControlsContainer";
            this.ControlsContainer.Padding = new System.Windows.Forms.Padding(5);
            this.ControlsContainer.Size = new System.Drawing.Size(485, 389);
            this.ControlsContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 414);
            this.Controls.Add(this.ControlsContainer);
            this.Controls.Add(this.lstMessage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIY_微博";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发布ToolStripMenuItem;
        protected internal System.Windows.Forms.ListBox lstMessage;
        private System.Windows.Forms.ToolStripMenuItem 文字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 获取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        protected internal System.Windows.Forms.FlowLayoutPanel ControlsContainer;
    }
}

