using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeiBo_DIY
{
    public partial class ucWeiBoInfo : UserControl
    {
        dynamic status;
        MainForm MainForm;
        public ucWeiBoInfo(MainForm pMainForm, dynamic pStatus)
        {
            InitializeComponent();
            MainForm = pMainForm;
            status   = pStatus;

            //对微博信息控件各项赋值
            this.lblUserName.Text    = status.user.screen_name + ":";
            this.txtStatusInfo.Text  = status.text;

            //对转发的微博添加源博微博信息
            if (status.IsDefined("retweeted_status"))
            {
                //this.txtStatusInfo.Font = new System.Drawing.Font(this.Font,FontStyle.Bold );
                this.txtStatusInfo.AppendText("\n");
                this.txtStatusInfo.AppendText("\n");
                this.txtStatusInfo.AppendText("☞☞☞☞   转自-->    " + status.retweeted_status.user.screen_name + ":" + 
                    status.retweeted_status.text);
                
            }

            this.pcUserFace.Load(status.user.profile_image_url);

        }

        private void txtRepost_MouseDown(object sender, MouseEventArgs e)
        {
            txtRepost.Text = "";
        }

        private void toolRepost_Click(object sender, EventArgs e)
        {
            try
            {
                status.Repost(status.id, txtRepost.Text, 0);
                MainForm.lstMessage.Items.Insert(0, "转发成功！" + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                MainForm.lstMessage.Items.Add(ex.Message);
            }
            
        }

        private void toolRepostComment_Click(object sender, EventArgs e)
        {
            try
            {
                status.Repost(status.id, txtRepost.Text, 3);
                MainForm.lstMessage.Items.Insert(0, "转发成功！" + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                MainForm.lstMessage.Items.Insert(0,ex.Message +DateTime.Now.ToString());
            }
        }

        private void btnRepost_Click(object sender, EventArgs e)
        {
            cmsRepost.Show(Cursor.Position );
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
 
            cmsComment.Show(Cursor.Position);
        }

        private void txtComment_MouseDown(object sender, MouseEventArgs e)
        {
            txtComment.Text = "";
        }

        private void toolComment_Click(object sender, EventArgs e)
        {
            try
            {
                NetDimension.Weibo.Client Client=new NetDimension.Weibo.Client(Authorize.oauth);
                NetDimension.Weibo.Interface.Dynamic.CommentInterface comment = new NetDimension.Weibo.Interface.Dynamic.CommentInterface(Client);
                comment.Create(status.id, txtComment.Text );
                MainForm.lstMessage.Items.Insert(0, "评论成功！" + DateTime.Now.ToString());

            }
            catch (Exception ex)
            {
                MainForm.lstMessage.Items.Insert(0, ex.Message + DateTime.Now.ToString());
            }
        }

    }
}
