using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMoShou
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
        }

       
        private void lblregister_Click(object sender, EventArgs e)
        {
            FrmRegist regist = new FrmRegist();

            regist.fl = this;
            regist.Show();
            this.Hide();
        }

        public  LoginInfo[] array;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            array = new LoginInfo[10];
            LoginInfo info1 = new LoginInfo();
            info1.Name = "孙丽丽";
            info1.Id = 20171227;
            info1.Email = "lili@sohu.com";
            info1.Password = "lili123";
            array[0] = info1;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "" || txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("用户名和密码都不能为空！", "提示");
            }
            else {
                string name = txtEmail.Text;
                string pwd = txtPwd.Text;
                bool isok = false;
                foreach(LoginInfo  item in array){
                    if(item!=null){
                        if (item.Email == name && item.Password == pwd)
                        {
                            isok = true;
                            FrmMain fm = new FrmMain();
                            fm.lblName.Text = "欢迎，" + item.Name;
                            fm.Show();
                            break;
                        }
                       
                    }
                }
            }

        }
    }
}
