// Responsibility: Represents a physical shipping address.
// Behavior: Stores street, city, state/province, and country. 
//           Determines whether the address is in the USA and formats the full address for labels.
public class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _stateProvince = "";
    private string _country = "";

    // Constructor(s)
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress.Trim();
        _city = city.Trim();
        _stateProvince = stateProvince.Trim();
        _country = country.Trim();

    }

    public bool IsCountryUSA()
    {
        if (_country.ToLower() == "usa" || _country.ToLower() == "united states")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetCompleteAddress()
    {
        return $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
    }

}
