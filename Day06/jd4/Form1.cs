using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jd4
{
    public partial class SimATM : Form
    {
        public SimATM()
        {
            InitializeComponent();
            lblBalance2.Text = "";
            lblNumber2.Text = "";
            lblUserName2.Text = "";
            CardType();
        }

        Dictionary<string,BankCard> bc = new Dictionary<string,BankCard>();
        public void CardType() {
            MyBank mb = new MyBank("1234","1234","吴梦洁",1000);
            OtherBank ob = new OtherBank("4321","4321","赵迪",5000);
            bc.Add("1234",mb);
            bc.Add("4321",ob);
        }

        //插卡
        private void btnInsertCard_Click(object sender, EventArgs e)
        {
            if (txtCard2.Text == "" || txtPwd2.Text == "")
            {
                MessageBox.Show("文本框不能为空");
            }
            else {
                string UserName=txtCard2.Text;
                bool flag=bc.ContainsKey(UserName);
                if (flag)
                {
                    string pwd= txtPwd2.Text;
                    BankCard ba = bc[UserName];
                    if (pwd.Equals(ba.Pwd))
                    {
                    lblNumber2.Text = bc[txtCard2.Text].Number;
                    lblUserName2.Text = bc[txtCard2.Text].Name;
                    btnSearch.Enabled = true;
                    btnAtm.Enabled = true;
                    if (ba is MyBank)
                    {
                        btnTransfer.Enabled = true;
                    }
                    }
                    else {
                        MessageBox.Show("密码不正确！");
                    }
                }
                else {
                    MessageBox.Show("没有此用户");                   
                }
            }
        }

        //查询
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblBalance2.Text = bc[txtCard2.Text].Balance.ToString();
            
        }

        //取款

        private void btnAtm_Click(object sender, EventArgs e)
        {

            lblBalance2.Text = bc[txtCard2.Text].GetMoney(Convert.ToInt32(txtMoney.Text)).ToString();
            MessageBox.Show("取款成功");
        }

        //转账
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            bc[txtCard2.Text].Balance -= Convert.ToInt32(txtSum.Text);
            lblBalance2.Text = bc[txtCard2.Text].Balance.ToString();
            bc[txtNumber.Text].Balance += Convert.ToInt32(txtSum.Text);
             
            MessageBox.Show("转账成功");
             

        }

        //退卡
        private void btnBackCard_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            btnAtm.Enabled = false;
            btnTransfer.Enabled = false;
            lblBalance2.Text = "";
            txtMoney.Clear();
            txtSum.Clear();
            txtNumber.Clear();
            lblNumber2.Text = "";
            lblUserName2.Text = "";
            txtCard2.Clear();
            txtPwd2.Clear();
        }


    }
}
