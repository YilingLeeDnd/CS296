using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int index = 1; index <= 10; index++)
            {
                Vector[] vectors = Vector.Generate(-100, 101, 10);
                Vector.WriteLine(vectors);
            }
        }
    }
}