﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jd3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();
            Shape re = new Rect();
            re.Draw();
            Console.ReadLine();
        }
    }
}
