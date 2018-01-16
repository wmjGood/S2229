using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck("一汽大众","中国");
            truck.VehicleRun();
            truck.TruckRun();
            Console.ReadLine();
        }
    }
}
