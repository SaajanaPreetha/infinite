using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }

    public Product(int productId, string productName, decimal price)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
    }

    public override string ToString()
    {
        return $"Product ID: {ProductId}, Name: {ProductName}, Price: {Price:C}";
    }
}

class Program
{
    static void Main()
    {
        // Sample products
        List<Product> products = new List<Product>
        {
            new Product(1, "Apple", 100),
            new Product(2, "Stickers", 20),
            new Product(3, "Soap", 462),
            new Product(4, "Earrings", 115),
            new Product(5, "Beans", 65),
            new Product(6, "Pen", 120),
            new Product(7, "Pencil", 76),
            new Product(8, "Notebooks", 640),
            new Product(9, "Sketchbook", 54),
            new Product(10, "Chocolates", 60)
        };

        // Sort products by price
        products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));

        // Display sorted products
        Console.WriteLine("Sorted Products:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
