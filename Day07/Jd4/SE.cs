using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jd4
{
    public class SE:Payroll
    {
        public int Basic { get; set; }

        public SE(int basic) {
            this.Basic = basic;
        }
        public override void PrintSalary()
        {
            Console.WriteLine("工程师的基本工资"+Basic);
        }
    }
}
