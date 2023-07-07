using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create products for Order 1
        Product product1Order1 = new Product();
        product1Order1.SetName(GenerateRandomProductName());
        product1Order1.SetProductId(GenerateRandomProductId());
        product1Order1.SetPrice(10.5m);
        product1Order1.SetQuantity(2);

        Product product2Order1 = new Product();
        product2Order1.SetName(GenerateRandomProductName());
        product2Order1.SetProductId(GenerateRandomProductId());
        product2Order1.SetPrice(15.0m);
        product2Order1.SetQuantity(1);

        // Create customer address for Order 1
        Address addressOrder1 = new Address();
        addressOrder1.SetStreetAddress("123 Main St");
        addressOrder1.SetCity("New York");
        addressOrder1.SetStateProvince("NY");
        addressOrder1.SetCountry("USA");

        // Create customer for Order 1
        Customer customerOrder1 = new Customer();
        customerOrder1.SetName("John Smith");
        customerOrder1.SetAddress(addressOrder1);

        // Create order 1
        Order order1 = new Order();
        order1.Products = new List<Product> { product1Order1, product2Order1 };
        order1.Customer = customerOrder1;

        // Create products for Order 2
        Product product1Order2 = new Product();
        product1Order2.SetName(GenerateRandomProductName());
        product1Order2.SetProductId(GenerateRandomProductId());
        product1Order2.SetPrice(8.0m);
        product1Order2.SetQuantity(3);

        Product product2Order2 = new Product();
        product2Order2.SetName(GenerateRandomProductName());
        product2Order2.SetProductId(GenerateRandomProductId());
        product2Order2.SetPrice(12.5m);
        product2Order2.SetQuantity(2);

        // Create customer address for Order 2
        Address addressOrder2 = new Address();
        addressOrder2.SetStreetAddress("456 Elm St");
        addressOrder2.SetCity("Los Angeles");
        addressOrder2.SetStateProvince("CA");
        addressOrder2.SetCountry("USA");

        // Create customer for Order 2
        Customer customerOrder2 = new Customer();
        customerOrder2.SetName("Jane Doe");
        customerOrder2.SetAddress(addressOrder2);

        // Create order 2
        Order order2 = new Order();
        order2.Products = new List<Product> { product1Order2, product2Order2 };
        order2.Customer = customerOrder2;

        // Display order details for Order 1
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        // Display order details for Order 2
        Console.WriteLine("Order 2 Details:");
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());

        Console.ReadLine();
    }

    static string GenerateRandomProductName()
    {
        string[] products = { "T-Shirt", "Sunglasses", "Running Shoes", "Headphones", "Backpack", "Watch" };
        Random random = new Random();
        return products[random.Next(products.Length)];
    }

    static string GenerateRandomProductId()
    {
        Random random = new Random();
        return "P" + random.Next(1000, 9999);
    }
}
