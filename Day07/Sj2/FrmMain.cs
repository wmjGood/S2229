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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.dgvDoWork.AutoGenerateColumns = false;
            Init();
        }


        List<Job> list = new List<Job>();
        SE se;
        //初始化
        public void Init() {
            
             
           list.Add(new CodeJob("实现购物车模块","编码","编码"));
            list.Add(new CodeJob("完成项目基类编码", "编码", "编码"));
            list.Add(new TestJob("测试","测试项目以实现模块",  "测试"));
             se = new SE("王小毛","s101",20,list);
             this.dgvDoWork.DataSource = se.list;
            this.grbDoWork.Text = se.Name;

        }

        //执行
        private void 执行ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int index = this.dgvDoWork.CurrentRow.Index;
            se.list[index].Execute();
        }

        //完成情况
        private void 完成情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.dgvDoWork.CurrentRow.Index;
            MessageBox.Show(se.list[index].Show(),"指标完成情况");
            

        }
    }
}
