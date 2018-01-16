using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jd5
{
    class Program
    {
        static void Main(string[] args)
        {
            Keeper keep = new Keeper();
            keep.Hey(new Lion());
            keep.Hey(new Monkey());
            keep.Hey(new Pigeon());
            Console.ReadLine();
        }
    }
}
