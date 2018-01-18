using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesineManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //点击预定，打开子窗体会议室预定窗体
        private void 预定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsert add = new FrmInsert();
            add.MdiParent = this; //以子窗体打开
            add.Show();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //以子窗体形式打开FrmSelect
            FrmSelect fr = new FrmSelect();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //退出程序
            Application.Exit();
        }
    }
}
