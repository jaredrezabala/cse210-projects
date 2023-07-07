using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product();
        product1.SetName("Product 1");
        product1.SetProductId("P1");
        product1.SetPrice(10.5m);
        product1.SetQuantity(2);

        Product product2 = new Product();
        product2.SetName("Product 2");
        product2.SetProductId("P2");
        product2.SetPrice(15.0m);
        product2.SetQuantity(1);

        // Create customer address
        Address address = new Address();
        address.SetStreetAddress("123 Main St");
        address.SetCity("New York");
        address.SetStateProvince("NY");
        address.SetCountry("USA");

        // Create customer
        Customer customer = new Customer();
        customer.SetName("John Smith");
        customer.SetAddress(address);

        // Create order
        Order order = new Order();
        order.Products = new List<Product> { product1, product2 };
        order.Customer = customer;

        // Display order details
        Console.WriteLine("Order Details:");
        Console.WriteLine("Total Cost: $" + order.CalculateTotalCost());
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());

        Console.ReadLine();
    }
}
