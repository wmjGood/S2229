using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj1
{
    //钢琴类
   public class Piano:Instrument
    {
       public override string Play()
       {
           string str = string.Format("钢琴在演奏");
           return str;
       }
    }
}
