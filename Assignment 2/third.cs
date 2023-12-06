using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass2_Ques3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Average of Array = " + MathHelper.CalculateAverage(num));
        }
    }
    public static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Length;
        }
    }
}