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
        decimal total = 0;
        foreach (Product product in _productList)
        {
            total += product.GetProductCost();
        }
        return total;
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
