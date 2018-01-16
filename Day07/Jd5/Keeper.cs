using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jd5
{
   public class Keeper
    {
       public void Hey(Pet pet) {
           Console.WriteLine("饲养员喂");
           pet.Eat();
       }
    }
}
