using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass2_Ques5
{
    internal partial class Person
    {
        string first, last;
        public void Get()
        {
            Console.WriteLine("Enter First Name : ");
            first = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            last = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Get();
            p.Show();
        }
    }
}