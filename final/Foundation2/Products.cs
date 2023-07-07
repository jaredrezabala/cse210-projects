public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetProductId(string productId)
    {
        this.productId = productId;
    }

    public string GetProductId()
    {
        return productId;
    }

    public void SetPrice(decimal price)
    {
        this.price = price;
    }

    public decimal GetPrice()
    {
        return price;
    }

    public void SetQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    public int GetQuantity()
    {
        return quantity;
    }
}
