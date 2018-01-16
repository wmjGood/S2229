using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj4
{
    //厨房
    class Kitchen
    {
        //菜单
        private Menu cai;
        //获得菜单
        public void GetMenu(Menu menu)
        {
            this.cai = menu;

        }
        public void Cook() {
            Console.WriteLine("厨师烹饪：{0}",cai.mealList);
            Console.WriteLine("制作完毕");
        }

        public void SendAlerrt(Service ser) {
            Console.WriteLine("厨师提示服务员取菜");
            ser.GetMenu(cai);
        }
    }
}
