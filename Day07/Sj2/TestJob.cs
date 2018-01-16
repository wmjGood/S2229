using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj2
{
     public class TestJob:Job
    {
        public int TestNum { get; set; }
        public int FindBug { get; set; }
        public int WorkDay { get; set; }
      
         public TestJob() { }
        public TestJob(string name,string type,string description) :base(description,name,type)
        { 
          
        }

        public override void Execute()
        {
            FrmTest frm = new FrmTest(this);
            frm.ShowDialog();
        }

        public override string Show()
        {
            string str = string.Format("测试用例个数{0}\n发现的Bugs数量{1}\n所需工作日{2}",TestNum,FindBug,WorkDay);
            return str;
        }

    }
}
