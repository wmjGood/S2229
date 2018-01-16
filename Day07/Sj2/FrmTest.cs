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
    public partial class FrmTest : Form
    {
        TestJob testjob;
        public FrmTest(TestJob test)
        {
            InitializeComponent();
            testjob = test;
        }

       
        //提交
        private void btnSubmitted_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            try {
                testjob.TestNum = Convert.ToInt32(txtTest.Text);
                testjob.FindBug = Convert.ToInt32(txtpub.Text);
                testjob.WorkDay = Convert.ToInt32(txtWorkDay.Text);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                isOk = true;
            }
            if(!isOk){
                MessageBox.Show("提交成功","提示");
                this.Close();
            }
            

        }
    }
}
