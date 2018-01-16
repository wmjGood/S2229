using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj2
{
   public class SE
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public List<Job> list { get; set; }

        public SE() { }
        public SE(string name,string id,int age,List<Job> list) {
            this.Age = age; 
            this.ID = id;
            this.Name = name;
            this.list = list;
        }
    }
}
