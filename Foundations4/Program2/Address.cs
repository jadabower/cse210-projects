public class Address
{
    string _street;
    string _city;
    string _state;
    string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsAmericanAddress()
    {
        if (_country.ToLower() == "america" || _country.ToLower() == "us" || _country.ToLower() == "usa" || _country.ToLower() == "united states of america")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string Stringify()
    {
        return ($"{_street}\n{_city}, {_state}\n{_country}");
    }
}