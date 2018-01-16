using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sj2
{
    public partial class FrmType : Form
    {
        CodeJob f;
        public FrmType(CodeJob frm)
        {
            InitializeComponent();
            f = frm;
        }

       
       //提交
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            try
            {
            f.CodeLine =Convert.ToInt32(this.txtLines.Text) ;
            f.Bugs = Convert.ToInt32(txtproblem.Text);
            f.WorkDay = Convert.ToInt32(txtDay.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isOk = true;
            }
            if (!isOk)
            {
                MessageBox.Show("提交成功", "提示");
                this.Close();
            }
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
