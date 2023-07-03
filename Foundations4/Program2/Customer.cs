public class Customer
{
    string _name;
    Address _address;
    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsShippingToUSA()
    {
        return _address.IsAmericanAddress();
    }
    public string GetCustomerName()
    {
        return _name;
    }
    public string GetCustomerAddress()
    {
        return _address.Stringify();
    }
}