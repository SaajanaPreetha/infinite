using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3ques3
{
    public class Saledetails
    {
        private int salesNo;
        private int productNo;
        private double price;
        private DateTime dateOfSale;
        private int qty;
        private double totalAmount;

        public Saledetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.qty = qty;
            this.dateOfSale = dateOfSale;

            CalculateTotalAmount();
        }

        private void CalculateTotalAmount()
        {
            totalAmount = qty * price;
        }

        public void ShowData()
        {
            Console.WriteLine($"Sales No: {salesNo}");
            Console.WriteLine($"Product No: {productNo}");
            Console.WriteLine($"Price: {price:C}"); 
            Console.WriteLine($"Quantity: {qty}");
            Console.WriteLine($"Date of Sale: {dateOfSale.ToShortDateString()}");
            Console.WriteLine($"Total Amount: {totalAmount:C}"); 
        }

        public static void Main(string[] args)
        {
            Saledetails sale1 = new Saledetails(1, 56, 350, 24, DateTime.Now);
            sale1.ShowData();
            Console.ReadLine();
        }
    }
}
