using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_Array
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2 };
            string[] names = new string[] { "鬼斯通", "耿鬼" };
            int index = 0;
            Console.Write("請輸入寶可夢編號：");
            int.TryParse(Console.ReadLine(), out index);
            Console.WriteLine("ID： {0} Name： {1}", numbers[index], names[index]);
        }
    }
}