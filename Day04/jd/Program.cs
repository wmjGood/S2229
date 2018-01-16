using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd
{
    class Program
    {
        static void Main(string[] args)
        {
            Property property = new Property("魔法师", 10000);
            property.show();
            Property property2 = new Property("阿修罗", 10000, 70, 200000);
            property2.show1();
            Console.ReadLine();
        }
    }
}
