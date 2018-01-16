using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jd4
{
   public class PE:Payroll
    {
       public int Basic { get; set; }
       public int Bonus { get; set; }

        public PE(int basic,int bonus) {
            this.Basic = basic;
            this.Bonus = bonus;
        }
       public override void PrintSalary()
       {

           Console.WriteLine("项目经理的工资为"+(Basic+Bonus));
       }
    }
}
