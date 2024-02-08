using ConsoleApp10.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            byte n = byte.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("\nCommom, used or imported (c/ u / i)? ");
                string selector = Console.ReadLine().ToLower();

                Console.Write("Enter the name of the product: ");
                string name = Console.ReadLine();

                Console.Write("Enter the price of the product: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (selector == "i")
                {
                    Console.Write("Enter customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (selector == "u")
                {
                    Console.Write("Enter manufacture date: ");
                    DateTime manufactureData = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureData));
                }

                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");

            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
