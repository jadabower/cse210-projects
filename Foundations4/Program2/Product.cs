public class Product
{
    string _name;
    string _productID;
    double _pricePerUnit;
    int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _productID = id;
        _pricePerUnit = price;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public double GetTotalPrice()
    {
        return (double)_quantity * _pricePerUnit;
    }
}