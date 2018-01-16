using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jd5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //绘制
        private void btnDraw_Click(object sender, EventArgs e)
        {

            
            Graphics g =(Graphics)picPanel.CreateGraphics();
            Pen p;
            if(rdoRed.Checked==true){
                 p = new Pen(Color.Red);
            }
            else if (rdoBlue.Checked == true)
            {
                p = new Pen(Color.Blue);
            }
            else {
                 p = new Pen(Color.Yellow);
            }
            
            Rectangle rec = new Rectangle(30, 30, 150, 150);
            if (rdoRound.Checked == true)
            {
                Circle c = new Circle();
                c.Draw(g,p);
               
            }
            else { 
             //g.DrawRectangle(p, rec);
                Rect r = new Rect();
                r.Draw(g,p);
            }

           
            

        }

        private void picPanel_Paint(object sender, PaintEventArgs e)
        {
            
            //this.picPanel.Invalidate();
        }
    }
}
