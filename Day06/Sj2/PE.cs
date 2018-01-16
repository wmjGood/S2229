using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj2
{
  public  class PE:Employee
    {
        public int Year { get; set; }
        public override string DoWork()
        {
          string message =this.Name+ "管理员完成工作内容";
          return message;
      }
      public PE(string id,string name,int age,string gender,List<Job> worklist,int year):base(age,id,name,gender,worklist) {
          this.Year = year;
       }
    }
}
