using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        internal class Account
        {
            public string AccountNumber { get; set; }
            public string HolderName { get; set; }
            public double Balance { get; set; }

            public Account(string accountNumber, string holderName, double balance = 0.0)
            {
                AccountNumber = accountNumber;
                HolderName = holderName;
                Balance = balance;
            }

            public void Deposit(double amount)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ₹{amount}. New Balance: ₹{Balance}");
            }

            public void Withdraw(double amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrew ₹{amount}. New Balance: ₹{Balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }

            public void DisplayBalance()
            {
                Console.WriteLine($"Account Balance: ₹{Balance}");
            }
        }

        internal class SavingsAccount : Account
        {
            public double InterestRate { get; set; }

            public SavingsAccount(string accountNumber, string holderName, double balance = 0.0, double interestRate = 0.05)
                : base(accountNumber, holderName, balance)
            {
                InterestRate = interestRate;
            }

            public void ApplyInterest()
            {
                double interest = Balance * InterestRate;
                Balance += interest;
                Console.WriteLine($"Interest of ₹{interest} applied. New Balance: ₹{Balance}");
            }
            static void Main(string[] args)
            {
                SavingsAccount acc = new SavingsAccount("SB001", "Amit Kumar", 1000.0);
                acc.DisplayBalance();
                acc.Deposit(500);
                acc.Withdraw(200);
                acc.ApplyInterest();

                Console.ReadLine();

            }
        }
    }
}
