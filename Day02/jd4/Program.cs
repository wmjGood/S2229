using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] money = { 500, 480, 320, 130, 210 };
            Console.WriteLine("**********打折促销**********");
            Console.WriteLine("购买商品的原价：");
            for (int a = 0; a < money.Length; a++)
            {
                Console.Write("{0}\t", money[a]);
            }
            Console.WriteLine("");
            Discount d = new Discount();
            d.show(money);
            Console.WriteLine("打折后的应付价钱：");
            //Show( money);
            for (int b = 0; b < money.Length; b++)
            {
                Console.Write("{0}\t", money[b]);
            }
            Console.ReadLine();
        }
    }
}
