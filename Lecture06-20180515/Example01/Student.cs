using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Student
    {
        public int number;
        public string chtName;
        public string engName;
        public string birthday;
        public string tel;
        public string email;

        public Student(int number, string chtName, string engName, string birthday, string tel, string email)
        {
            this.number = number;
            this.chtName = chtName;
            this.engName = engName;
            this.birthday = birthday;
            this.tel = tel;
            this.email = email;
        }
    }
}