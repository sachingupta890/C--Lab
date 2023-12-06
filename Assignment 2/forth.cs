using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass2_Ques4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.LogMessage("Hello World");
        }
    }
    public static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine("Log : " + message);
        }
    }

}