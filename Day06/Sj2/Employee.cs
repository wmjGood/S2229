using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj2
{
   public class Employee
    {
        public int Age { get; set; }
        public string ID { get; set; }
        public string  Name { get; set; }
        public string Gender { get; set; }
        public List<Job> WorkList { get; set; }
        public  Employee(int age,string id,string name,string gender,List<Job> worklist) {
            this.Age = age;
            this.Gender = gender;
            this.ID = id;
            this.Name = name;
            this.WorkList = worklist;

        }
        public virtual string DoWork() {
            string mess = string.Format("大家好");
            return mess;
        }

       
    }
}
