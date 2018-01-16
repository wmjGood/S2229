using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd4
{
    //银行卡类
   public class BankCard
    {
       //卡号
        public string Number { get; set; }
       //密码
        public string Pwd { get; set; }
       //用户名
        public string Name { get; set; }
       //余额
        public int Balance { get; set; }
        
       //取款
       public virtual int GetMoney(int money){
           return 0;
       }
    }
}
