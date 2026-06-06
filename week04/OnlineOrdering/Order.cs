// Responsibility: 
// Behavior: 
public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;

    // Constructor(s)
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }
    public decimal GetTotalCost() 
    {
        decimal subtotal = 0;
        decimal shippingCost;
        foreach (Product product in _productList)
        {
            subtotal += product.GetProductCost();
        }
        if (IsCountryUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return subtotal + shippingCost;
    }
    public bool IsCountryUSA()
    {
        return _customer.IsCountryUSA();
    }
    public void DisplayPackingLbl()
    {
        // Display Packing lbl
    }
    public void DisplayShippingLbl()
    {
        // Display Shipping lbl
    }

}
