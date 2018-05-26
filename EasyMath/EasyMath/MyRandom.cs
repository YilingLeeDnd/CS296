using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    internal class MyRandom
    {
        private Random random;

        public MyRandom()
        {
            random = new Random();
        }

        public int Next()
        {
            return random.Next();
        }

        public int Next(int min, int max)
        {
            return random.Next(min, max);
        }

        public double NextDouble()
        {
            return random.NextDouble();
        }

        //產生任何一個範圍的浮點數
        public double NextDouble(double min, double max)
        {
            double x = random.NextDouble();
            return (max - min) * x + min;
        }
    }
}