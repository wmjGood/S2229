using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd4
{
    //本行类
  public  class MyBank:BankCard
    {

      public MyBank() { }
      public MyBank(string num,string pwd,string name,int money)
      {
          this.Number = num;
          this.Pwd = pwd;
          this.Name = name;
          this.Balance = money;
      }
      public override int GetMoney(int money)
      {
          
          base.Balance= this.Balance - money;
          return base.Balance;
      }
    }
}
