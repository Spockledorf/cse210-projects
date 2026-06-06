using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("633 N Milwaukee St", "Boise", "Idaho", "USA");
        Customer customer1 = new Customer("Targesh LeBron", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("ApplePeach Pie", 1, (decimal)6.21, 5);

        order1.AddProduct(product1);

        order1.DisplayPackingLbl();
        order1.DisplayShippingLbl();

    }
}