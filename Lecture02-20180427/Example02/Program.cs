using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入一個數字");
            try
            {
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("您輸的數字是{0}", number1);
            }
            catch
            {
                Console.WriteLine("輸入有問題喔!");
            }

            //double number1 = float.Parse(Console.ReadLine());
            //string number2 = (4.12345678).ToString("#.##"); //#.##顯示的格式
            //Console.WriteLine(number1);
            //Console.WriteLine(number2);
        }
    }
}