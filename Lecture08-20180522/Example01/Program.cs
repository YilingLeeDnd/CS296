using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] args = int args[];
            //Employee a = new Employee();
            Employee a = EmployeeFactory.Create(args[0]);
            a.SayHello();
            //Employee b = new Sales();
            Employee b = EmployeeFactory.Create(args[1]);
            b.SayHello();
        }
    }

    public class Employee
    {
        public string Name { get; set; }

        public virtual void SayHello()
        {
            Console.WriteLine("Hi");
        }
    }

    public class Sales : Employee
    {
        public override void SayHello()
        {
            base.SayHello(); //用base繼承Employee的"Hi"
            Console.WriteLine("今天賺很多");
        }
    }

    //靜態工廠方法模式
    public class EmployeeFactory
    {
        public Employee Create(int type)
        {
            switch (type)
            {
                case 1:
                    return new Employee();

                case 2:
                    return new Sales();

                default:
                    return new Employee();
            }
        }
    }
}