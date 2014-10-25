using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeiBo_DIY
{
    public partial class PublishForm : Form
    {
        MainForm mainForm;
        int funcNo;  //区分功能，1为文字，2为图文
        public PublishForm(MainForm pMainForm,int i)
        {
            InitializeComponent();
            mainForm = pMainForm;
            funcNo = i;
        }

        private void PublishForm_Load(object sender, EventArgs e)
        {
            if (funcNo == 1)
            {
                btnSelectPic.Enabled = false;
            }
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfldlg = new OpenFileDialog();
            Openfldlg.InitialDirectory = @"C:\Users\Public\Pictures";
            Openfldlg.Filter = "JPEG文件|*.jpg|GIF文件|*.gif|PNG文件|*.png|图像文件|*.jpg;*.gif;*.png";
            Openfldlg.RestoreDirectory = true;
            Openfldlg.Title = "打开图像";

            if (Openfldlg.ShowDialog() == DialogResult.OK)
            {
                pb.Load(Openfldlg.FileName);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                //实例化一个操作类，用刚才成功获得了AccessToken的OAuth实例
                NetDimension.Weibo.Client Sina = new NetDimension.Weibo.Client(Authorize.oauth);
            if (funcNo == 1)
            {
                Sina.API.Dynamic.Statuses.Update(textBox1.Text  + DateTime.Now.ToLongTimeString());
                mainForm.lstMessage.Items.Insert(0, "发布成功." + DateTime.Now.ToString());
                this.Close();
            }
            else if (funcNo == 2)
            {
                if (pb.Image != null)
                {

                    try
                    {
                        byte[] Byte = BasicFunc.ImageToByte(pb.Image);
                        Sina.API.Dynamic.Statuses.Upload(textBox1.Text, Byte);
                        mainForm.lstMessage.Items.Insert(0, "发布成功." + DateTime.Now.ToString());
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        mainForm.lstMessage.Items.Add(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("请选择图片！");
                }//if image
            }//if funcNo
        }//void
    }
}
