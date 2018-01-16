using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
    class Money
    {
        public void Pay(SE se) {
            int sum = se.Baispay + se.Meritpay;
            Console.WriteLine("基本工资：{0}", se.Baispay);
            Console.WriteLine("考核工资：{0}", se.Meritpay);
            Console.WriteLine("程序员的工资：{0}",sum);
        }
        public void Pay(PE pe) {
            int sum = pe.BasePay + pe.Magprize + pe.Bonus;
            Console.WriteLine("基本工资：{0}", pe.BasePay);
            Console.WriteLine("项目奖金：{0}", pe.Magprize);
            Console.WriteLine("分红：{0}", pe.Bonus);
            Console.WriteLine("项目经理的工资：{0}", sum);
        }
    }
}
