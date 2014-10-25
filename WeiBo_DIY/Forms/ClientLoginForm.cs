using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WeiBo_DIY
{
    public partial class ClientLoginForm : Form
    {
        MainForm mainForm;
        bool txtChanged=false ;
        public ClientLoginForm(MainForm pMainForm)
        {
           
            InitializeComponent();
            mainForm = pMainForm;
            this.txtPassport.Text = LoginPrometers.Passport;
            this.txtPassword.Text = LoginPrometers.Password;
        }

        protected internal  void btnOK_Click(object sender, EventArgs e)
        {
            if (txtChanged)
            {
                FileStream fs = File.OpenWrite(Application.StartupPath + @"\ClientLogin.txt");
                StreamWriter sr = new StreamWriter(fs as Stream);
                sr.WriteLine(txtPassport.Text);
                sr.WriteLine(txtPassword.Text);
                sr.Close();
            }
            try
            {
                //初始化oAuth，准备认证
                Authorize.oauth  = new NetDimension.Weibo.OAuth(txtAppKey.Text, txtAppSecret.Text, txtCallbackURL.Text);
                //简化的认证流程，直接调用ClientLogin。这个方法不需要去申请password方式的认证，只是模拟了上面的步骤并进行了封装
                var result = Authorize.oauth.ClientLogin(txtPassport.Text, txtPassword.Text);
                //返回值为bool型，为true则表示授权、登录成功。为false的话，要不密码错了，要不就是回调地址和新浪后台里面填写的不一样

                //mainForm.lstMessage.Visible = true;
                //mainForm.ControlsContainer.Visible = true;
               if(result)
                 mainForm.lstMessage.Items.Insert(0, "登录成功！" + DateTime.Now.ToString());
                
                this.Close();
                mainForm.TopMost = true;
            }
            catch(Exception ex){
                mainForm.lstMessage.Items.Insert(0, ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.TopMost = true;
        }

        private void txtPassport_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
        }
    }
}
