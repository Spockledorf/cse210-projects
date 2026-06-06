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
        // A packing label should list the name and product id of each product in the order.
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("      ------- Packing Label --------");
        Console.WriteLine("------------------------------------------");

    }
    public void DisplayShippingLbl()
    {
        // Display Shipping lbl
        // A shipping label should list the name and address of the customer.
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("     -------- Shipping Label --------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Customer: {_customer.GetCustomerName()}");
        Console.WriteLine($"Address: {_customer.GetCustomerAddress()}");
        if (IsCountryUSA())
        {
            Console.WriteLine("   [✓] Shipping inside USA");
        }
        else
        {
            Console.WriteLine("   [✗] Shipping outside USA");
        }
    }

}
