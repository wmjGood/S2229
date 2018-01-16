using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj4
{
   public class OperationReduce: Operation
    {
       public override double Reault()
       {
           double result = Number1 - Number2;
           return result;
       }
    }
}
