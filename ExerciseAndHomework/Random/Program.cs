using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[5];     //產生5個數字的陣列
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 21);    //從1~20中產生亂數

                for (int j = 0; j < i; j++)
                {
                    while (numbers[j] == numbers[i])    //檢查是否有數字相同
                    {
                        j = 0;
                        numbers[i] = random.Next(1, 21);   //當有重覆數字時，重新產生亂數
                    }
                }
                Console.WriteLine(numbers[i]);
            }
        }
    }
}