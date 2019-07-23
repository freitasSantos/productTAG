using System;
using TagProduct.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace TagProduct {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of the products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());
                switch (c) {
                    case 'c':
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Product product = new Product(name, price);
                        list.Add(product);
                        break;
                    case 'u':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        product = new UsedProduct(name, price, date);
                        list.Add(product);
                        break;
                    case 'i':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        product = new ImportedProduct(name, price, customsFee);
                        list.Add(product);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product obj in list) {
                Console.WriteLine(obj.PriceTag());
            }
        }
    }
}
