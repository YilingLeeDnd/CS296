using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_TryParse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number = 0;
            Console.Write("請輸入一個數字：");
            string str = Console.ReadLine();
            bool success = int.TryParse(str, out number);
            Console.WriteLine("使用者輸入的是{0}, 轉換成功? {1}", str, success);
        }
    }
}