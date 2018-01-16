using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj1
{
    class Program
    {
        static void Main(string[] args)
        {
            SE se = new SE("110","哈哈","男",22);
           se.SayHi();
            PE pe = new PE("110", "呵呵", "女", 18);
            pe.SayHi();
            Console.ReadLine();
        }
    }
}
