using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj4
{
    class Program
    {
        static void Main(string[] args)
        {
            PetDoctor pd = new PetDoctor();
            pd.Visit(new Pig());
            pd.Visit(new Bird());
            pd.Visit(new Dog());
            Console.ReadLine();
        }
    }
}
