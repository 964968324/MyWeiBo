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
    public partial class LoginForm : Form
    {
        int t = 0;
        MainForm mainForm;
        public LoginForm(MainForm pMainForm)
        {
            InitializeComponent();
            mainForm = pMainForm;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                t++;
                //首次点击获取CODE码
                if (t == 1)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    string appkey = textBox1.Text;
                    string appsecret = textBox2.Text;
                    string callbackurl = textBox3.Text;
                    Authorize.StartAuth(appkey, appsecret, callbackurl);

                    button1.Text = "再次确定";
                }
                //二次点击获取授权
                else if (t == 2)
                {
                    string code = textBox4.Text;
                    Authorize.TakeAccess(code);
                    mainForm.lstMessage.Visible = true;
                    mainForm.ControlsContainer.Visible = true;
                    mainForm.lstMessage.Items.Insert(0, Authorize.accessToken.ToString()+DateTime.Now.ToString());
                    this.Close();
                    mainForm.TopMost = true;
                }
            }//try
            catch (Exception ex)
            {
                mainForm.lstMessage.Items.Insert(0, ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.TopMost = true;
        }
    }
}
