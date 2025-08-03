using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address canadaAddress = new Address("456 Oak Rd", "Vancouver", "BC", "Canada");
        
        // Create customers
        Customer usaCustomer = new Customer("John Smith", usaAddress);
        Customer intlCustomer = new Customer("Emma Johnson", canadaAddress);
        
        // Create products
        Product laptop = new Product("Laptop", "P100", 899.99, 1);
        Product mouse = new Product("Wireless Mouse", "P101", 24.99, 2);
        Product keyboard = new Product("Mechanical Keyboard", "P102", 59.95, 1);
        Product monitor = new Product("4K Monitor", "P103", 299.99, 1);

        // Create first order
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(laptop);
        order1.AddProduct(mouse);
        
        Console.WriteLine("ORDER 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTOTAL: ${order1.CalculateTotal():F2}\n");
        Console.WriteLine(new string('-', 40));

        // Create second order
        Order order2 = new Order(intlCustomer);
        order2.AddProduct(keyboard);
        order2.AddProduct(monitor);
        order2.AddProduct(mouse);
        
        Console.WriteLine("\nORDER 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTOTAL: ${order2.CalculateTotal():F2}");
    }
}