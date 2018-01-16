using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer[] computer = new Computer[3];
            Computer com = new Computer();
            com.type = "hpCq-217";
            com.datatime="2017-12-30";
            computer[0] = new Computer();
            computer[0] = com;
            Computer com2 = new Computer();
            com2.type = "Mc240Ch";
            com2.datatime = "2017-12-30";
            computer[1] = new Computer();
            computer[1] = com2;
            Computer com3 = new Computer();
            com3.type = "System021";
            com3.datatime = "2017-12-30";
            computer[2] = new Computer();
            computer[2] = com3;
            Console.WriteLine("计算机型号    计算机Id    购买时间");
            for (int i = 0; i < computer.Length;i++ ) {
                Console.Write(computer[i].type+"\t");
                Console.Write(computer[i].ID + "\t");
                Console.WriteLine(computer[i].datatime + "\t");
               
            }
            Console.WriteLine("****************生成ID后******************");
            Random rd = new Random();
            computer[0].ID = rd.Next(1000, 9999);
            computer[1].ID = rd.Next(1000, 9999);
            computer[2].ID = rd.Next(1000, 9999);
            for (int i = 0; i < computer.Length; i++)
            {
                Console.Write(computer[i].type + "\t");
                Console.Write(computer[i].type +"-"+ computer[i].ID + "\t");
                Console.WriteLine(computer[i].datatime + "\t");

            }
            Console.ReadLine();
        }
    }
}
