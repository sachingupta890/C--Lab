using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass2_Ques5
{
    internal partial class Employee
    {
        string Name;
        float BasicSal;
        public void Get()
        {
            Console.WriteLine("Enter the name of Salary : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the base Salary : ");
            BasicSal=float.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Get();
            emp.Show();
        }
    }
}
