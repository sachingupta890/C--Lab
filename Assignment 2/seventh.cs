using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass2_Ques7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine("Working of Circle class : ");
            circle.Get();
            Console.WriteLine("The Area of Circle is : " + circle.CalculateArea());
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Working of Circle class : ");
            rectangle.Get();
            Console.WriteLine("The Area of Circle is : " + rectangle.CalculateArea());
        }
    }
    public abstract class Shape
    {
        public abstract float CalculateArea();
    }
    public class Circle:Shape
    {
        float Radius,Area;
        public void Get()
        {
            Console.WriteLine("Enter the radius of Circle : ");
            Radius = float.Parse(Console.ReadLine());
        }
        public override float CalculateArea()
        {
            Area = (float)3.14 * Radius * Radius;
            return Area;
        }
    }
    public class Rectangle : Shape
    {
        float Length,Breadth, Area;
        public void Get()
        {
            Console.WriteLine("Enter the Length of Rectangle : ");
            Length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Length of Rectangle : ");
            Breadth = float.Parse(Console.ReadLine());
        }
        public override float CalculateArea()
        {
            Area = (float)Length*Breadth;
            return Area;
        }
    }
}