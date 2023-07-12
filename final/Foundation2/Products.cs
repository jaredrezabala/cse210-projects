public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetProductId(string productId)
    {
        _productId = productId;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}