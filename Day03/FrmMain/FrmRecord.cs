using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmRecord : Form
    {
       public  FrmMain fr=new FrmMain();
        public FrmRecord(FrmMain f)
        {
            f = fr;
            InitializeComponent();
        }
       

        private void FrmRecord_Load(object sender, EventArgs e)
        {
            
        }
       

    }
}
