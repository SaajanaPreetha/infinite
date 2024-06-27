using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD

=======
>>>>>>> 8c7edff8c3f997c4f1d68c4c38f5d539dfc46266
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
<<<<<<< HEAD

=======
>>>>>>> 8c7edff8c3f997c4f1d68c4c38f5d539dfc46266
    static List<Product> GetProducts()
    {
        List<Product> products = new List<Product>();
        for (int i = 1; i <= 10; i++)  
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
<<<<<<< HEAD

    static void SortProducts(List<Product> products)
    {
        products.Sort(new ProductComparer());
    }

    class ProductComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }

=======
    
    static void SortProducts(List<Product> products)
    {
        products.Sort(new ProductComparer());
    }

    class ProductComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }

>>>>>>> 8c7edff8c3f997c4f1d68c4c38f5d539dfc46266
    static void DisplayProducts(List<Product> products)
    {
        Console.WriteLine("\nSorted Products:");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
}
