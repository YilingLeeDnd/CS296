using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public static class RandomExtension
    {
        //需擴充的功能是誰
        public static double NextDouble(this Random random, double min, double max)
        {
            double x = random.NextDouble();
            return (max - min) * x + min;
        }
    }
}