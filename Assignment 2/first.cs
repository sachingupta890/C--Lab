using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass2_Ques1
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.SetDetails();
            employee.ShowDetails();
        }
    }
    internal class Employee
    {
        String Name;
        int Age;
        float Salary;
        public void SetDetails()
        {
            Console.Write("Enter The Name of Employee : ");
            Name = Console.ReadLine();
            Console.Write("Enter The Age of Employee : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Salary of Employee : ");
            Salary = float.Parse(Console.ReadLine());
        }
        public void ShowDetails()
        {
            Console.WriteLine("Name of Employee is : " + Name);
            Console.WriteLine("Age of Employee is : " + Age);
            Console.WriteLine("Salary of Employee is : " + Salary);
        }
    }
}