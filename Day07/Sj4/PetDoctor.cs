using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj4
{
    public class PetDoctor
    {

        public void Visit(Pet pet)
        {
            Console.WriteLine("兽医给");
            pet.Tohospital();
        }
    }
}
