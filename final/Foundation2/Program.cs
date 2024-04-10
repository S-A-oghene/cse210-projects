using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Product 1", "P1", 3m, 5);
        Product product2 = new Product("Product 2", "P2", 4m, 3);
        Product product3 = new Product("Product 3", "P3", 5m, 2);

        // Create addresses
        Address address1 = new Address("123 Main St.", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St.", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Doe", address2);

        // Create orders
        List<Product> products1 = new List<Product> { product1, product2 };
        List<Product> products2 = new List<Product> { product3 };
        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        // Display order information
        Console.WriteLine($"Packing Label: {order1.PackingLabel()}");
        Console.WriteLine($"Shipping Label: {order1.ShippingLabel()}");
        Console.WriteLine($"Total Cost: {order1.TotalCost():C}");
        Console.WriteLine();

        Console.WriteLine($"Packing Label: {order2.PackingLabel()}");
        Console.WriteLine($"Shipping Label: {order2.ShippingLabel()}");
        Console.WriteLine($"Total Cost: {order2.TotalCost():C}");

    }
}