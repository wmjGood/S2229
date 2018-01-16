using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj4
{
   public class OperationDiv:Operation
    {
        public override double Reault()
        {
            if(Number2==0){
                throw new Exception("除数不能为0！");
            }
            double result = Number1 / Number2;
            return result;
        }
    }
}
