using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj1
{
   public class SE
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Pop { get; set; }

        public SE() { }

        public SE(string name,string id,int pop) {
            this.Name = name;
            this.ID = id;
            this.Pop = pop;
        }
        public void Play(Instrument ins) {
            ins.Play();
        }

    }
}
