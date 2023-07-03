public class Order
{
    Customer _customer;
    List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    private double GetShippingPrice()
    {
        if (_customer.IsShippingToUSA())
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }
    private double CalculateTotalCost()
    {
        double price = 0.0;
        foreach(Product product in _products)
        {
            price += product.GetTotalPrice();
        }
        price += GetShippingPrice();
        return price;
    }
    private string GetPackingLabel()
    {
        string packingLabel = "";
        foreach(Product product in _products)
        {
            packingLabel += $"{product.GetProductName()} - {product.GetProductID()}\n";
        }
        return packingLabel;
    }
    private string GetShippingLabel()
    {
        string shippingLabel = $"{_customer.GetCustomerName()}\n";
        shippingLabel += _customer.GetCustomerAddress();
        return shippingLabel;
    }
    public void DisplayOrder()
    {
        Console.WriteLine("========================================");
        Console.WriteLine($"Total Price: {CalculateTotalCost()}");
        Console.WriteLine();
        Console.Write(GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine("========================================");
    }
}