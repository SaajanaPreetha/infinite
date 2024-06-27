using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4ques3
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException() { }

        public InsufficientBalanceException(string message)
            : base(message) { }

        public InsufficientBalanceException(string message, Exception innerException)
            : base(message, innerException) { }
    }
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            this.balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            this.balance += amount;
            Console.WriteLine($"Successfully deposited ${amount}. New balance: ${this.balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (amount > this.balance)
                throw new InsufficientBalanceException("Insufficient balance to withdraw.");

            this.balance -= amount;
            Console.WriteLine($"Successfully withdrawn ${amount}. New balance: ${this.balance}");
        }

        public decimal CheckBalance()
        {
            return this.balance;
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(1500);

            try
            {
                account.Deposit(300);
                account.Withdraw(2000);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception: {ex.Message}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Insufficient Balance Exception: {ex.Message}");
            }

            decimal currentBalance = account.CheckBalance();
            Console.WriteLine($"Current balance: ${currentBalance}");
            Console.ReadLine();
        }
    }
}
