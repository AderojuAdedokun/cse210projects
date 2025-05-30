using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main()
        {
            // Create customers and addresses
            var addr1 = new Address("123 Cocoa St", "Lagos", "LA", "Nigeria");
            var customer1 = new Customer("Christiana Chocogoddess", addr1);

            var addr2 = new Address("456 Main Ave", "New York", "NY", "USA");
            var customer2 = new Customer("John Doe", addr2);

            // Order #1
            var order1 = new Order(customer1);
            order1.AddProduct(new Product("Press-On Set", "PS100", 12.99m, 2));
            order1.AddProduct(new Product("Nail Polish", "NP200", 5.50m, 3));

            // Order #2
            var order2 = new Order(customer2);
            order2.AddProduct(new Product("Makeup Palette", "MP300", 24.75m, 1));
            order2.AddProduct(new Product("Lipstick", "LS400", 8.25m, 2));
            order2.AddProduct(new Product("Mascara", "MC500", 9.99m, 1));

            // Display Order #1
            Console.WriteLine("=== Order 1 ===");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
             Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():0.00}");
            Console.WriteLine();

            // Display Order #2
            Console.WriteLine("=== Order 2 ===");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():0.00}");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
