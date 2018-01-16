using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sj4
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.cboHao.SelectedIndex = 0;
            lblResult2.Text = "";
        }

        //计算
        private void btnSum_Click(object sender, EventArgs e)
        {
            string type=this.cboHao.SelectedItem.ToString();
            Operation op = new Operation();
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("文本框不能为空");
            }
            else
            {

           Operation operation= OperationFactory.Gettance(type);
                
            }
                op.Number1 = Convert.ToDouble(txtNum1.Text);
                op.Number2 = Convert.ToDouble(txtNum2.Text);
                lblResult2.Text = op.Reault().ToString();
            
        }




    }
}
