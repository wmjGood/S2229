using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj1
{
   public class Violin:Instrument
    {
       public override string Play()
       {
           string str = string.Format("小提琴在演奏");
           return str;
       }
    }
}
