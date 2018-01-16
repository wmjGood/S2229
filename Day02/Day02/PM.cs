
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
  public  class PM
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string longevity;

        public string Longevity
        {
            get { return longevity; }
            set { longevity = value; }
        }
        public void UpdateSE(SE se, string Evaluation, string Rating) {
            se.Evaluate = Evaluation;
            se.Score = Rating;
        }
    }
}
