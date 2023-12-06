using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Ass3_Ques5_1;


namespace Lab_Ass3_Ques5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class2 c = new class2();
            c.show();
        }
    }
    class class2 : class1
    {
        public void show()
        {
            Console.WriteLine("The value of protected internal field is : " + Value);
        }
    }
}
