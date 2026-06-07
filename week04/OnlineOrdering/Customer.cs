// Responsibility: Represents a customer who places an order.
// Behavior: Stores the customer's name and their shipping address. 
//           Provides the customer's name and full address for use in packing and shipping labels.
public class Customer
{
    private string _name = "";
    private Address _address;

    // Constructor(s)
    public Customer(string name, Address address)
    {
        _name = name.Trim();
        _address = address;
    }

    public bool IsCountryUSA()
    {
        return _address.IsCountryUSA();
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetCustomerAddress()
    {
        return _address.GetCompleteAddress();
    }

 }
