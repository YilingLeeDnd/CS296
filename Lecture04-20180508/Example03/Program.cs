using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random(); //亂數，不可放在迴圏內，因為會因產生的時間太短，造成亂數會一群一群有重覆亂數

            for (int index = 0; index < numbers.Length; index++)
            {
                //numbers[index] = index + 1;
                numbers[index] = random.Next(1, 11);
                Console.WriteLine(numbers[index]);
            }
        }
    }
}