using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj1
{
    //乐器类 父类
   public class Instrument
    {
       public virtual string Play() {
           string str = string.Format("乐器在演奏");
           return str;
       }

    }
}
