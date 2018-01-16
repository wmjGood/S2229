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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            this.dgvPlay.AutoGenerateColumns = false;
            Init();
        }

        List<SE> list = new List<SE>();
        //初始化员工
        public void Init() {
            SE se = new SE("王小毛","s101",10);
            SE se2 = new SE("周新宇","s102",12);
            SE se3 = new SE("小花","s103",15);
            list.Add(se);
            list.Add( se2);
            list.Add( se3);
            //绑定DataGridview
            this.dgvPlay.DataSource = list;
            
        }

        private void 演奏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMian frm = new FrmMian(this);
            frm.Show();
         
        }
    }
}
