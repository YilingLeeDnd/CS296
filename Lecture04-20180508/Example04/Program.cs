using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[3];
            Random random = new Random(); //亂數，不可放在迴圏內，因為會因產生的時間太短，造成亂數會一群一群有重覆亂數
            int total = 0; //變數不可放在迴圈內

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(1, 11); // 1~10寫法要寫(1, 11)
                total += numbers[index];
                Console.WriteLine(numbers[index]);
            }
            Console.WriteLine(total);
        }
    }
}