using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMain
{
   public  class Record
    {
        public DateTime SignInTime { get; set; }
        public DateTime SignOutTime { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
