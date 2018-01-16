using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();
            SE se = new SE();
            se.Baispay = 6000;
            se.Meritpay = 2000;

            money.Pay(se);
            PE pe = new PE();
            pe.BasePay = 8000;
            pe.Magprize = 2000;
            pe.Bonus = 2000;
            money.Pay(pe);
            Console.ReadLine();

        }
    }
}
