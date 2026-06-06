// Responsibility: 
// Behavior: 
public class Product
{
    private string _productName = "";
    private int _productID;
    private decimal _unitPrice;
    private int _quantity;

    // Constructor(s)
    public Product(string productName, int productID, decimal unitPrice, int quantity)
    {
        _productName = productName.Trim();
        _productID = productID;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public decimal GetProductCost()
    {
        return (_unitPrice * _quantity);
    }

}
