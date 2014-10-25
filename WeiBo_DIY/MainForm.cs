using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetDimension.Weibo;
using NetDimension.Json;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace WeiBo_DIY
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

   

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new LoginForm(this)).Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void 调用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Authorize.oauth == null)
            {
                MessageBox.Show("请先登录！");
                return;
            }

            try
            {
                //实例化一个操作类，用刚才成功获得了AccessToken的OAuth实例
                NetDimension.Weibo.Client Sina = new NetDimension.Weibo.Client(Authorize.oauth);
                //调用各种方法
                var JsonText = Sina.API.Dynamic.Statuses.FriendsTimeline(null, null, 1) ;
                BasicFunc.ShowStatus(this, JsonText);
                foreach (var status in JsonText.statuses)
                {
                    if (status.IsDefined("user"))	//这里要判断下是不是有user这个项，一般微博被删除了就不会返回user，直接xxx.user要出错。
                    {
                        lstMessage.Items.Insert(0, status);//打印用户名和他说的内容

                    }
                }

            }//try
            catch (Exception ex)
            {
                lstMessage.Items.Insert(0, ex.Message);
            }

        }


        private void MainForm_Load(object sender, EventArgs e)
        {

            //lstMessage.Visible = false;
            //ControlsContainer.Visible = false;

            //直接用户登录
           

            StreamReader  sr = File.OpenText(Application.StartupPath+ @"\ClientLogin.txt");
            LoginPrometers.Passport = sr.ReadLine().Trim();
            LoginPrometers.Password = sr.ReadLine().Trim();
            sr.Close();
            ClientLoginForm ClientLoginForm = new ClientLoginForm(this);
            ClientLoginForm.btnOK_Click(null, null);

        }

        private void 文字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Authorize.oauth  == null)
            {
                MessageBox.Show("请先登录！");
                return;
            }
            (new PublishForm(this, 1)).Show();
        }

        private void 图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Authorize.oauth == null)
            {
                MessageBox.Show("请先登录！");
                return;
            }
            (new PublishForm(this,2)).Show();
        }

        private void clientLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ClientLoginForm(this)).Show();
     
        }

        private void toolStripTextBox1_MouseEnter(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
        }


        //加载微博信息
        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Authorize.oauth == null)
            {
                MessageBox.Show("请先登录！");
                return;
            }
            if (e.KeyChar != 032)
                return;
            int count;
            if (int.TryParse(toolStripTextBox1.Text, out count))
            {
                工具ToolStripMenuItem.HideDropDown();
                try
                {
                    //实例化一个操作类，用刚才成功获得了AccessToken的OAuth实例
                    NetDimension.Weibo.Client Sina = new NetDimension.Weibo.Client(Authorize.oauth);
                    //调用各种方法
                    var JsonText = Sina.API.Dynamic.Statuses.FriendsTimeline(null, null, count);
                    //BasicFunc.JsonInfo(this, JsonText);
                    BasicFunc.ShowStatus(this, JsonText);
                }//try
                catch (Exception ex)
                {
                    lstMessage.Items.Insert(0, ex.Message);
                }
            }
            else
                MessageBox.Show("请输入一个整数！", "错误警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
