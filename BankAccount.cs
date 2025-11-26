using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Balance cannot be zero or negative.");
                balance = value;
            }
        }

        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            Balance = initialBalance; // uses validation
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            balance += amount;
            Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be positive.");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}. New Balance: {balance}");
        }
    }
}
