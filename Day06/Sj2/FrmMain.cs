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
            Insert();
        }
        //存储员工
        List<Employee> em = new List<Employee>();
        public void Insert() {
            //存储工作
            List<Job> job=new List<Job>();
            Job job2 = new Job("编码","购物车模块");
            job.Add(job2);
            //员工
            SE item = new SE("呵呵","女",22,job,50,"S101");
            em.Add(item);

            //经理
            List<Job> Pejob=new List<Job>();
            Job Pejob2 = new Job("监督项目", "购物车模块");
            Pejob.Add(Pejob2);
            PE pe = new PE("Y101","哈哈",30,"男",Pejob,10);
            em.Add(pe);
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
           
            foreach(Employee emp in em){
                MessageBox.Show(emp.DoWork());
            }
          
        }
    }
}
