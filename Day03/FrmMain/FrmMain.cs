using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
      

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmAdd fr = new FrmAdd();
            fr.f = this;
            fr.li = pList;
           
            fr.Show();
          
        }

       
        private void FrmMain_Load(object sender, EventArgs e)
        {
          
        }

        SE se = new SE();
       public   List<SE> pList = new List<SE>();
        public void BindingList(List<SE> list) {
            dataGridView1.DataSource = new BindingList<SE>(pList);
        }
        //查询
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<SE> list = new List<SE>();
            foreach (SE item in this.pList)
            {
                if (item.Number.IndexOf(this.txtNumber.Text.Trim())!=-1)
                {
                    list.Add(item);
                }
            }
            dataGridView1.DataSource = new BindingList<SE>(list);
        }

        //删除
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32( dataGridView1.SelectedCells[0].Value.ToString());
            DialogResult result = MessageBox.Show("确定要删除吗？","提示",MessageBoxButtons.YesNo);
            if(result== DialogResult.Yes){
                for (int i = 0; i < pList.Count;i++ ) {
                    if (pList[i].Number == num.ToString())
                    {
                        pList.RemoveAt(i);
                        dataGridView1.DataSource = new BindingList<SE>(pList);
                        break;
                    }
                }
            }
            
        }

      public   Dictionary<string, Record> recordList = new Dictionary<string, Record>();

        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1){
                MessageBox.Show("请选择一行");
                return;
            }
            string work = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            foreach(string id in recordList.Keys){
                if(work==id){
                    MessageBox.Show("您已签过到");
                    return;
                }
                 
            }
            Record re = new Record();
            re.ID = work;
            re.Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            re.SignInTime = DateTime.Now;
            this.recordList.Add(re.ID,re);
            MessageBox.Show("签到成功！");
        }

        private void 签退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count!=1){
                MessageBox.Show("请选中一行");
                return;
            }
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bool isOut = false;
            foreach(string key in recordList.Keys){
               if(key==id){
                   this.recordList[key].SignOutTime = DateTime.Now;
                   MessageBox.Show("签退成功");
                   isOut = true;
                   break;
               }
            }
            if(!isOut){
                MessageBox.Show("对不起，尚未签到");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
           
            FrmRecord re = new FrmRecord(this);
           re. dgvList.AutoGenerateColumns = false;
          
            BindingSource bs = new BindingSource();
            bs.DataSource = recordList.Values;
            re.dgvList.DataSource = bs;
            re.lblNumber.Text = bs.Count.ToString();
            re.Show();
        }


     
        
     

    }
}
