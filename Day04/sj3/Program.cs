using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            string Carname = "沃尔沃";
            string CarColour = "银灰";
            string Carsite = "中国";
            int speed = 230;
            car.Run(Carname, CarColour, Carsite);
            car.Run(Carname, CarColour, Carsite, speed);
            Console.ReadLine();
        }
    }
}
