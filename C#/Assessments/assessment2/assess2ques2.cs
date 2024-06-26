using System;
using System.Collections.Generic;

// Define the Product class
public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, double price)
    {
        ProductId = id;
        ProductName = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Product(ID: {ProductId}, Name: {ProductName}, Price: {Price:C})";
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = GetProducts();
        SortProducts(products);
        DisplayProducts(products);
    }

    // Function to accept products from user input
    static List<Product> GetProducts()
    {
        List<Product> products = new List<Product>();
        for (int i = 1; i <= 10; i++)  // Accepting 10 products
        {
            Console.WriteLine($"Enter details for Product {i}:");
            Console.Write("Enter Product ID: ");
            int productId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Product product = new Product(productId, productName, price);
            products.Add(product);
        }
        return products;
    }

    // Function to sort products based on price
    static void SortProducts(List<Product> products)
    {
        products.Sort(new ProductComparer());
    }

    // ProductComparer class to compare products based on price
    class ProductComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }

    static void DisplayProducts(List<Product> products)
    {
        Console.WriteLine("\nSorted Products:");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
}
