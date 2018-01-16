using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{   
    class student
    {
        public string name;
        public int age;
        public int exp;

        public student()
        {
            name = "Rob";
            age = 22;
            exp = 0;
        }
        public override string ToString()
        {
            return name + " " + age + " " + exp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student a = new student();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
