using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd5
{
    //长方形
   public class Rect:Shape
    {
        public override void Draw(Graphics g, Pen p)
        {
           
            Rectangle rec = new Rectangle(30, 30, 150, 150);
            g.DrawRectangle(p, rec);
        }
    }
}
