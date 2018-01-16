using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj4
{
    //服务员
    class Service
    {
        private Menu menu;
        
        public void GetMenu(Menu menu) {
            this.menu = menu;
        }
        public void SendMenu(Kitchen kit) {
            Console.WriteLine("服务员将菜{0}传给厨师",menu.mealList);
            kit.GetMenu(menu);
        }
        public void TransCook() {
            Console.WriteLine("服务员将菜{0}送给顾客{1}",menu.mealList,menu.id);
            menu.name.Eat();
        }
    }
}
