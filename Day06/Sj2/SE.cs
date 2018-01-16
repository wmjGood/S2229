using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sj2
{
   public class SE:Employee
    {
        private int _popularity;

        public int Popularity
        {
            get { return _popularity; }
            set { _popularity = value; }
        }
        public override string DoWork() {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name+"\n");
            for (int i = 0; i < WorkList.Count;i++ ) {
                sb.Append((i + 1) + "、" + WorkList[i].Name + ":" + WorkList[i].Description + "\n");
            }
            return sb.ToString();
        }
        public SE(string name,string gender,int age,List<Job> worklist,int pop,string id):base(age,id,name,gender,worklist) {

            this._popularity = pop;
        }
       
    }
}
