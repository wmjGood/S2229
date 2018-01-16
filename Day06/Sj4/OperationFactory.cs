using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj4
{
   public class OperationFactory
    {
       public static Operation Gettance(string type){
           Operation op = null;
           switch (type)
           {
               case "+":
                        {
                            op = new OperationAdd();
                            break;
                        }
                    case "-":
                        {
                            op = new OperationReduce();

                            break;

                        }
                    case "*":
                        {
                            op = new OperationRide();
                            break;
                        }
                    case "/":
                        {
                            op = new OperationDiv();
                            break;
                        }
           }
           return op;
       }
     
    }
}
