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
            //檢查mail格式是否正確
            string mail = "abc@gmail.com";
            int atPosition = mail.IndexOf("@");
            int dotPostion = mail.IndexOf(".");
            bool isMail =
                (atPosition > 0) &&
                (atPosition < dotPostion) &&
                (dotPostion <= mail.Length - 2);

            Console.WriteLine("{0} 是合法的mail嗎？ {1}", mail, isMail);

            int? number = null; //如果要寫null，要在型號的地方寫一個?
        }
    }
}