using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sj1
{
    public partial class FrmMian : Form
    {
        Form1 f;
        public FrmMian(Form1 frm)
        {
            InitializeComponent();
            f = frm;
            string name = f.dgvPlay.SelectedRows[0].Cells[1].Value.ToString();
            this.grbPlay.Text = name + "开始演奏";
        }

        private void btnPaly_Click(object sender, EventArgs e)
        {
            Instrument ins=null;
            if(rdoSachs.Checked==true){
                ins = new Sachs();
                MessageBox.Show(ins.Play(),"信息！");
               
            }if(rdoViolin.Checked==true){
                ins = new Violin();
                MessageBox.Show(ins.Play(),"信息！");
            }
            if(rdoPiano.Checked==true){
                ins = new Piano();
                MessageBox.Show(ins.Play(),"信息！");
            }
           
        }
    }
}
