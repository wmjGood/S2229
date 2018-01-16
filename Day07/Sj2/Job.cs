using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj2
{
   public abstract class Job
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Job() { }
        public Job(string description,string name,string type) {
            this.Description = description;
            this.Name = name;
            this.Type = type;
        }
        public abstract void Execute();

        public abstract string Show();
    }
}
