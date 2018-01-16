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
    public partial class FrmRegist : Form
    {
        public FrmRegist()
        {
            InitializeComponent();
        }


        private void FrmRegist_Load(object sender, EventArgs e)
        {

        }

        public FrmLogin fl;
        
        public bool isnull() {
           
            bool isok = true;
            if (txtCardNum.Text.Trim() == null || txtCardNum.Text.Trim()=="") {
                isok = false;
            }if(txtEmail.Text.Trim()==null || txtEmail.Text.Trim()==""){
                isok = false;
            } 
            if (txtEmail2.Text.Trim() == null || txtEmail2.Text.Trim() == "") 
            {
                isok = false;
            }
            if (txtname.Text.Trim() == null || txtname.Text.Trim() == null) {
                isok = false;
            }
            if (txtpwd.Text.Trim() == null || txtpwd.Text.Trim() == null) {
                isok = false;
            }
            if (txtpwd2.Text.Trim() == null || txtpwd2.Text.Trim() == null) {
                isok = false;
            }
           
            return isok;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (isnull())
            {
                if (txtEmail.Text != txtEmail2.Text || txtpwd.Text != txtpwd2.Text)
                {
                    MessageBox.Show("请输入一致的邮件登录名或密码");
                }
                else
                {
                    LoginInfo info = new LoginInfo();
                    info.Name = txtname.Text;
                    info.Email = txtEmail.Text;
                    info.Password = txtpwd.Text;
                    MessageBox.Show("恭喜，通过验证！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = 0; i < fl.array.Length; i++)
                    {
                        if (fl.array[i] == null)
                        {
                           fl.array[i] = info;
                            break;
                        }
                    }
                    fl.Visible = true;
                    if(fl.txtEmail.Text.Trim()!=null || fl.txtPwd.Text.Trim()!=null){
                        fl.txtEmail.Clear();
                        fl.txtPwd.Clear();
                    }
                    this.Close();
                }
            }
            else {
                MessageBox.Show("请填写相关信息");
            }
        }
    }
}
