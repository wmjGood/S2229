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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Init();
            Update();
        }

        public SE [] engineers = new SE[3];
        public void Init() {
            engineers[0] = new SE();
            engineers[0].Name = "王小毛";
            engineers[0].Number = "111";
            engineers[0].Sex = "男";
            engineers[0].Evaluate = "未评价";
            engineers[0].Score = "0";
            engineers[1] = new SE();
            engineers[1].Name = "周新宇";
            engineers[1].Number = "222";
            engineers[1].Sex = "女";
            engineers[1].Evaluate = "未评价";
            engineers[1].Score = "0";
            engineers[2] = new SE();
            engineers[2].Name = "张烨";
            engineers[2].Number = "333";
            engineers[2].Sex = "女";
            engineers[2].Evaluate = "未评价";
            engineers[2].Score = "0";
        }
        public void Update() {
            lvSelect.Items.Clear();
            for (int i = 0; i < engineers.Length;i++ ) {
                ListViewItem item = new ListViewItem(engineers[i].Number);
                item.SubItems.Add(engineers[i].Name);
                item.SubItems.Add(engineers[i].Sex);
                item.SubItems.Add(engineers[i].Evaluate);
                item.SubItems.Add(engineers[i].Score);
                this.lvSelect.Items.Add(item);
            }
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if(lvSelect.SelectedItems.Count==0){
                return;
            }
           
            int index=0;
            for (int i = 0; i < engineers.Length; i++)
            {
                if(engineers[i].Number==lvSelect.SelectedItems[0].Text){
                    index = i;
                    break;
                }
            }
            FrmSelect se = new FrmSelect(index,this);
            se.Show();
        }
    }
}
