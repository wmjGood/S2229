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
    public partial class FrmAdd : Form
    {
        public FrmMain f;
        public List<SE> li;
        public FrmAdd()
        {
            InitializeComponent();
         
            cboSex.SelectedIndex = 0;
        }

       
      
        private void btnSave_Click(object sender, EventArgs e)
        {    
                InsertList();
            
        }
        public void InsertList() {
            SE se = new SE();
                se.Number = txtNumber.Text;
                se.Age = Convert.ToInt32(txtAge.Text);
                se.Name = txtName.Text;
                if (cboSex.SelectedIndex == 0)
                {
                    se.Sex ="男";
                }
                else
                {
                    se.Sex ="女";
                }
                foreach(SE item in li){
                   if(se.Number==item.Number){
                       MessageBox.Show("此工号已存在");
                       return;
                   }
                }
                li.Add(se);
            
                f.BindingList(li);
            }
           
          
            
            
            
        }

    }

