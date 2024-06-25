using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3ques1
{
    public class Accounts
    {
        private string accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        public Accounts(string accountNo, string customerName, string accountType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = '\0'; 
            this.amount = 0.0;
            this.balance = 0.0;
        }

        private void Credit(double amount)
        {
            balance += amount;
        }

        private void Debit(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
        public void ProcessTransaction(char transactionType, double amount)
        {
            this.transactionType = transactionType;
            this.amount = amount;

            if (transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'W')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type!");
            }
        }

        public void ShowData()
        {
            Console.WriteLine("Account Number: " + accountNo);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Transaction Type: " + transactionType);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Balance: " + balance.ToString("C")); 
        }

        public static void Main(string[] args)
        {
            Accounts account = new Accounts("161126113420", "Saajana", "Savings");

            account.ProcessTransaction('D', 1500);
            account.ShowData(); 

            account.ProcessTransaction('W', 800); 
            account.ShowData(); 

            account.ProcessTransaction('W', 1000); 
            account.ShowData(); 
            Console.ReadLine();
        }
    }
}
