using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass2_Ques10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.GetDetails();
            account.ShowDetails();
            SavingAccount savingAccount = new SavingAccount();
            savingAccount.ShowInterest();
        }
    }
    public class BankAccount
    {
        string AccountNumber, AccountName;
        float Balance;
        public void GetDetails()
        {
            Console.WriteLine("Enter the Account Number : ");
            AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter the Account Name : ");
            AccountName = Console.ReadLine();
            Console.WriteLine("Enter the Initial Balance : ");
            Balance = float.Parse(Console.ReadLine());

        }
        public void ShowDetails()
        {
            Console.WriteLine("Name of Account Holder is : " + AccountName);
            Console.WriteLine("Number of Account is : " + AccountNumber);
            Console.WriteLine("Balance of Account is : " + Balance);
        }
        public float ReturnBal()
        {
            return this.Balance;
        }
    }
    public sealed class SavingAccount:BankAccount

    {
        public void ShowInterest()
        {
            Console.WriteLine("Interest for balance (7% per annum) : " + ((float)0.07 * ReturnBal()));
        }
    }
}