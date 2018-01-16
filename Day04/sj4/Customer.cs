using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj4
{
    //顾客
    class Customer
    {
        public void Order(Service ser,Menu menu) {
            Console.WriteLine("顾客点菜{0}", menu.mealList);
            ser.GetMenu(menu);
         }
        public void Eat() {
            Console.WriteLine("客人用餐");
        }
    }
}
