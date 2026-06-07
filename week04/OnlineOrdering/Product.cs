// Responsibility: 
// Behavior: 
using System.Security.Cryptography;

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
        return _unitPrice * _quantity;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {_productID,-7} Name: {_productName,-26} Unit Price (USD): ${_unitPrice,-7} QTY: {_quantity,4}");
    }

}
