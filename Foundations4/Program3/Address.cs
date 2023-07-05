public class Address
{
    string _street;
    string _city;
    string _state;
    string _zipCode;

    public Address(string street, string city, string state, string zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zip;
    }
    public string Stringify()
    {
        return ($"{_street}\n{_city}, {_state} {_zipCode}");
    }
}