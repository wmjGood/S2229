using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj4
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer wang = new Customer();
            Service ser = new Service();
            Service zhang = new Service();
            Kitchen kit = new Kitchen();
            Menu menu = new Menu();
            menu.name = wang;
            menu.id = 200;
            menu.mealList = "宫保鸡丁";
            wang.Order(ser,menu);
            ser.SendMenu(kit);
            kit.Cook();
            kit.SendAlerrt(ser);
            ser.TransCook();
            Console.ReadLine();
            
        }
    }
}
