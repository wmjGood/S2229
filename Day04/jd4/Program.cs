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
            Ant ant = new Ant();
            ant.Sweet();
            ant.Find();
            Call call = new Call();
            call.CallAnt();
            Handling hand = new Handling();
            hand.HandingSweet();
            Console.ReadLine();
        }
    }
}
