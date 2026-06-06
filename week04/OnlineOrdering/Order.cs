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
        // Add product
    }
    public decimal GetTotalCost() 
    {
        // Product.GetProductCost()
        return 0;
    }
    public bool IsCountryUSA()
    {
        // Customer.IsCountryUSA()
        return true;
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
