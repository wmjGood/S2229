using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj1
{
   public class Sachs:Instrument
    {
       public override string Play()
       {
           string str = string.Format("萨克斯在演奏");
           return str;
       }
    }
}
