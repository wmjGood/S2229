using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj2
{
  public  class CodeJob:Job
    {
        public int Bugs { get; set; }
        public int CodeLine { get; set; }
        public int WorkDay { get; set; }

        public CodeJob() { }
        public CodeJob(string des,string name,string type):base(des,name,type) {
        
        }

        public override void Execute()
        {
            FrmType frm = new FrmType(this);
            frm.Show();
        }
        public override string Show()
        {
            
            string str = string.Format("有效编码行数{0}\n遗留问题{1}\n所需工作日{2}", CodeLine, Bugs, WorkDay);
            return str;
        }

    }
}
