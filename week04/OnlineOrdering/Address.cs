using System;

public class Address
{

    private string _street;
    private string _address;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address(string street, string address, string city, string stateProvince, string country)
    {
        _street = street;
        _address = address;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public string CreateAddress()
    {
        return $"{_street} {_address} {_city}, {_stateProvince}, {_country}";
    }

    public bool CountryLocation()
    {
        if (_country == "USA")
            return true;

        else
        {
            return false;
        }
    }

}