using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass2_Ques2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, num;
            float Bal;
            Console.WriteLine("Enter the number of account : ");
            num=Console.ReadLine();
            Console.WriteLine("Enter the name of account holder : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the initial balance of account : ");
            Bal = float.Parse(Console.ReadLine());
            BankAccount bankAccount = new BankAccount(num, name, Bal);
            bankAccount.ShowDetails();
        }
    }
    internal class BankAccount
    {
        string AccountNumber, AccountName;
        float Balance;
        public BankAccount(string ANumber,string AName,float ABal)
        {
            AccountNumber= ANumber;
            AccountName= AName;
            Balance = ABal;
        }
        public void Deposit()
        {
            Console.WriteLine("Enter the Amount to be deposited : ");
            Balance+=float.Parse(Console.ReadLine());
            Console.WriteLine("The Updated Balance is : " + Balance);
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter the amount to withdraw : ");
            float bal=float.Parse(Console.ReadLine());
            if (bal <= Balance)
            { 
                Balance -= bal;
                Console.WriteLine("The amount is withdraw successfully !\nThe Updated Balance is : " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance!!");
            }
        }
        public void ShowDetails()
        {
            Console.WriteLine("Name of Account Holder is : " + AccountName);
            Console.WriteLine("Number of Account is : " + AccountNumber);
            Console.WriteLine("Balance of Account is : " + Balance);
        }
    }
}