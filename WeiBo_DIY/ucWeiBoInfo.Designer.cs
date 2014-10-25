namespace WeiBo_DIY
{
    partial class ucWeiBoInfo
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pcUserFace = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnRepost = new System.Windows.Forms.Button();
            this.cmsRepost = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtRepost = new System.Windows.Forms.ToolStripTextBox();
            this.toolRepost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRepostComment = new System.Windows.Forms.ToolStripMenuItem();
            this.txtStatusInfo = new System.Windows.Forms.TextBox();
            this.cmsComment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtComment = new System.Windows.Forms.ToolStripTextBox();
            this.toolComment = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcUserFace)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmsRepost.SuspendLayout();
            this.cmsComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcUserFace
            // 
            this.pcUserFace.Location = new System.Drawing.Point(3, 3);
            this.pcUserFace.Name = "pcUserFace";
            this.pcUserFace.Size = new System.Drawing.Size(50, 50);
            this.pcUserFace.TabIndex = 0;
            this.pcUserFace.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.Orange;
            this.lblUserName.Location = new System.Drawing.Point(73, 17);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 12);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "用户名";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 25);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer1.Location = new System.Drawing.Point(312, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnComment);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnRepost);
            this.splitContainer1.Size = new System.Drawing.Size(136, 25);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnComment
            // 
            this.btnComment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnComment.Location = new System.Drawing.Point(0, 0);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(44, 25);
            this.btnComment.TabIndex = 0;
            this.btnComment.Text = "评";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnRepost
            // 
            this.btnRepost.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRepost.Location = new System.Drawing.Point(0, 0);
            this.btnRepost.Name = "btnRepost";
            this.btnRepost.Size = new System.Drawing.Size(39, 25);
            this.btnRepost.TabIndex = 0;
            this.btnRepost.Text = "转";
            this.btnRepost.UseVisualStyleBackColor = true;
            this.btnRepost.Click += new System.EventHandler(this.btnRepost_Click);
            // 
            // cmsRepost
            // 
            this.cmsRepost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtRepost,
            this.toolRepost,
            this.toolRepostComment});
            this.cmsRepost.Name = "cmsRepost";
            this.cmsRepost.Size = new System.Drawing.Size(177, 73);
            // 
            // txtRepost
            // 
            this.txtRepost.Name = "txtRepost";
            this.txtRepost.Size = new System.Drawing.Size(100, 23);
            this.txtRepost.Text = "输入转发内容";
            this.txtRepost.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtRepost_MouseDown);
            // 
            // toolRepost
            // 
            this.toolRepost.Name = "toolRepost";
            this.toolRepost.Size = new System.Drawing.Size(176, 22);
            this.toolRepost.Text = "不作为评论转发(&R)";
            this.toolRepost.Click += new System.EventHandler(this.toolRepost_Click);
            // 
            // toolRepostComment
            // 
            this.toolRepostComment.Name = "toolRepostComment";
            this.toolRepostComment.Size = new System.Drawing.Size(176, 22);
            this.toolRepostComment.Text = "作为评论转发(&C)";
            this.toolRepostComment.Click += new System.EventHandler(this.toolRepostComment_Click);
            // 
            // txtStatusInfo
            // 
            this.txtStatusInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtStatusInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatusInfo.Location = new System.Drawing.Point(61, 39);
            this.txtStatusInfo.Multiline = true;
            this.txtStatusInfo.Name = "txtStatusInfo";
            this.txtStatusInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusInfo.Size = new System.Drawing.Size(378, 110);
            this.txtStatusInfo.TabIndex = 5;
            // 
            // cmsComment
            // 
            this.cmsComment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtComment,
            this.toolComment});
            this.cmsComment.Name = "cmsComment";
            this.cmsComment.Size = new System.Drawing.Size(161, 51);
            // 
            // txtComment
            // 
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(100, 23);
            this.txtComment.Text = "请输入评论内容";
            this.txtComment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtComment_MouseDown);
            // 
            // toolComment
            // 
            this.toolComment.Name = "toolComment";
            this.toolComment.Size = new System.Drawing.Size(160, 22);
            this.toolComment.Text = "发表评论";
            this.toolComment.Click += new System.EventHandler(this.toolComment_Click);
            // 
            // ucWeiBoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcUserFace);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtStatusInfo);
            this.Name = "ucWeiBoInfo";
            this.Size = new System.Drawing.Size(451, 184);
            ((System.ComponentModel.ISupportInitialize)(this.pcUserFace)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmsRepost.ResumeLayout(false);
            this.cmsRepost.PerformLayout();
            this.cmsComment.ResumeLayout(false);
            this.cmsComment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pcUserFace;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Button btnComment;
        public System.Windows.Forms.Button btnRepost;
        private System.Windows.Forms.ContextMenuStrip cmsRepost;
        private System.Windows.Forms.ToolStripTextBox txtRepost;
        private System.Windows.Forms.ToolStripMenuItem toolRepost;
        private System.Windows.Forms.ToolStripMenuItem toolRepostComment;
        private System.Windows.Forms.TextBox txtStatusInfo;
        private System.Windows.Forms.ContextMenuStrip cmsComment;
        private System.Windows.Forms.ToolStripTextBox txtComment;
        private System.Windows.Forms.ToolStripMenuItem toolComment;
    }
}
