using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj1
{
    class SE
    {

        public SE(string id,string name,string sex,int age){
            this.ID = id;
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
                

    }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public void SayHi() {
            Console.WriteLine("工号{0}，今年{1}，性别{2}，我叫{3}",ID,Age,Sex,Name);
        }
    }
}
