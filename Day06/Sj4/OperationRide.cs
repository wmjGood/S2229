using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj4
{
   public class OperationRide:Operation
    {
       public override double Reault()
       {
           double result = Number1 * Number2;
           return result;
       }
    }
}
