// Responsibility: Represents an address as strings for street address, city, state/province, and country.
// Behavior: Returns full address as a string. Can dertermine if address is in USA.
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
