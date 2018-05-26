using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入一個整數：");
            string str = Console.ReadLine();
            Console.WriteLine(float.Parse(str));

            Console.Write("請輸入妙蛙種子的HP：");
            int bulbsaurHp = int.Parse(Console.ReadLine());
            Console.WriteLine("妙蛙種子的HP是：{0}", bulbsaurHp);
        }
    }
}