using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("101 Fifth Ave", "New York", "NY", "USA");
        Address canadaAddress = new Address("123 Queen St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Alice Johnson", usaAddress);
        Customer customer2 = new Customer("Bob Robertson", canadaAddress);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B001", 12.99, 2));
        order1.AddProduct(new Product("Pen", "P123", 1.50, 5));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "H567", 29.99, 1));
        order2.AddProduct(new Product("USB Cable", "U999", 5.99, 3));

        Console.WriteLine("    Order 1    ");
        Console.WriteLine("--------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine("    Order 2    ");
        Console.WriteLine("--------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}\n");

    }
}