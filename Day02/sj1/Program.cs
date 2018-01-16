using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            int[] newscores = new int[5];
            Console.WriteLine("请输入5位会员的积分：");
            for (int i = 0; i < scores.Length;i++ ) {
                Console.Write("第"+(i+1)+"位会员的积分：");
                scores[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < scores.Length;i++ ) {
                newscores[i] = scores[i];
                newscores[i] =newscores[i]+ 500;

            }
            Console.WriteLine("序号   历史积分   新年积分");
            for (int i = 0; i < scores.Length;i++ ) {
                Console.Write((i + 1) + "\t" );
                Console.Write(scores[i] + "\t" );
                Console.WriteLine(newscores[i] + "\t" );
            }
            Console.ReadLine();
        }
    }
}
