using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class FrmSelect : Form
    {
        public SE se;
        public frmMain main;
        public FrmSelect(int index,frmMain frm)
        {
            InitializeComponent();
            this.main = frm;
            se = main.engineers[index];
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            PM pm = new PM();
            pm.UpdateSE(se, this.txtevaluate.Text.Trim(),this.txtScore.Text.Trim());
            this.main.Update();
        }

        private void FrmSelect_Load(object sender, EventArgs e)
        {
            txtname.Text = se.Name;
            txtScore.Text = se.Score;
            txtevaluate.Text = se.Evaluate;
        }

    }
}
