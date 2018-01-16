using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jd4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Payroll p = new SE(4000);
            Payroll p2 = new PE(4000,2000);
            p.PrintSalary();
            p2.PrintSalary();
            Console.ReadLine();
        }
    }
}
