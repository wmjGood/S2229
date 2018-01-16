using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd5
{
    //圆形
   public class Circle:Shape
    {
        public override void Draw(Graphics g, Pen p)
        {
           
            g.DrawEllipse(p, 30, 30, 100, 100);

        }
    }
}
