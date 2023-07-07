using System;
using System.Collections.Generic;

public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in Products)
        {
            totalCost += product.GetPrice() * product.GetQuantity();
        }

        if (Customer.IsInUSA())
        {
            totalCost += 5; // Shipping cost for customers in the USA
        }
        else
        {
            totalCost += 35; // Shipping cost for customers outside the USA
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in Products)
        {
            packingLabel += $"Product Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer Name: {Customer.GetName()}\n";
        shippingLabel += Customer.GetAddress().GetFullAddress();

        return shippingLabel;
    }
}
