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
            double bmi = 23.5;

            // TODO 如果bmi > 24不健康 或者 bmi < 不健康
            if (bmi > 24 || bmi < 18)
            {
                // TODO 顯示不健康的提示
                // StatusLabel.Text = "BMI異常，請注意健康！";
                Console.WriteLine("BMI異常，請注意健康！");
            }

            // TODO 不然 顯示健康的提示
            else
            {
                Console.WriteLine("BMI正常");
            }
        }
    }
}