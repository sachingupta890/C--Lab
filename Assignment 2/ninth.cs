using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass2_Ques9
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine is Started!");
        }
        public void StopEngine()
        {
            Console.WriteLine("Engine is Stopped!");
        }
    }
    public sealed class  Car : Vehicle
    {
        public void show()
        {
            Console.WriteLine("Showing Class Car inherited from Vehicle as Base Class");
        }
    }
    public class RolceRoyce : Car
    {
        //As we see there a error arises as we can't inherite the sealed class to a derive class.
    }

}