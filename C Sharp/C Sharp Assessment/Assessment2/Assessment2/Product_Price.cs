using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public class Productsid_price
    {
    public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
    }

    class Product_Price
    {
        static void Main()
        {
            List<Productsid_price> products = new List<Productsid_price>();

            for (int i = 0; i < 10; i++)
            {
                Productsid_price p = new Productsid_price();
                Console.Write($"Enter Product {i + 1} Id: ");
                p.ProductId = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter Product {i + 1} Name: ");
                p.ProductName = Console.ReadLine();
                Console.Write($"Enter Product {i + 1} Price: ");
                p.Price = Convert.ToDecimal(Console.ReadLine());
                products.Add(p);
            }

            var sortedProducts = products.OrderBy(p => p.Price);

            Console.WriteLine("Sorted Products:");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Name: {product.ProductName}, Id: {product.ProductId}, Price: {product.Price}");
                Console.ReadLine();
            }
        }
    }
}
