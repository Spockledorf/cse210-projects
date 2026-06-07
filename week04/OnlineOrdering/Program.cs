using System;

class Program
{
    static void Main(string[] args)
    {



        // Order #1
        Address address1 = new Address("633 N Milwaukee St", "Boise", "Idaho", "USA");
        Customer customer1 = new Customer("Targesh LeBron", address1);
        Order order1 = new Order(customer1);
        
        // Order #2
        Address address2 = new Address("Sta. Rosa 12", "Iquitos", "16001", "Peru");
        Customer customer2 = new Customer("Peru Man", address2);
        Order order2 = new Order(customer2);
        
        // Order #3
        Address address3 = new Address("Cape Henry Trail", "Virginia Beach", "Virgina", "USA");
        Customer customer3 = new Customer("Trailman Tom", address3);
        Order order3 = new Order(customer3);
        
        // Order #4
        Address address4 = new Address("222 S Cayuga St", "Ithaca", "New York", "USA");
        Customer customer4 = new Customer("Ithaca Hotel", address4);
        Order order4 = new Order(customer4);

        // Add products
        order1.AddProduct(new Product("ApplePeach Pie", 4821, (decimal)6.21, 5));
        order1.AddProduct(new Product("Blueberry Muffin", 392, (decimal)2.99, 12));
        order1.AddProduct(new Product("Chocolate Cake", 7154, (decimal)14.50, 2));
        order1.AddProduct(new Product("Cinnamon Roll", 58, (decimal)3.75, 8));
        
        order2.AddProduct(new Product("Croissant", 2937, (decimal)2.49, 20));
        order2.AddProduct(new Product("Strawberry Cheesecake", 6103, (decimal)18.95, 1));
        order2.AddProduct(new Product("Banana Bread", 814, (decimal)5.60, 6));
        order2.AddProduct(new Product("Lemon Tart", 4476, (decimal)7.30, 4));
        order2.AddProduct(new Product("Pecan Brownie", 9231, (decimal)3.10, 15));
        
        order3.AddProduct(new Product("Raspberry Danish", 1567, (decimal)4.25, 9));
        order3.AddProduct(new Product("Carrot Cake", 3048, (decimal)12.00, 3));
        
        order4.AddProduct(new Product("Glazed Donut", 729, (decimal)1.75, 24));
        order4.AddProduct(new Product("Pumpkin Bread", 5882, (decimal)6.80, 7));
        order4.AddProduct(new Product("Cherry Turnover", 8345, (decimal)3.50, 11));
        order4.AddProduct(new Product("Almond Biscotti", 2614, (decimal)2.20, 18));


        // Display All
        
        order1.DisplayPackingLbl();
        Console.WriteLine();
        order1.DisplayShippingLbl();
        Console.WriteLine($"Total: ${order1.GetTotalCost()}");
        
        order2.DisplayPackingLbl();
        Console.WriteLine();
        order2.DisplayShippingLbl();
        Console.WriteLine($"Total: ${order2.GetTotalCost()}");
        
        order3.DisplayPackingLbl();
        Console.WriteLine();
        order3.DisplayShippingLbl();
        Console.WriteLine($"Total: ${order3.GetTotalCost()}");
        
        order4.DisplayPackingLbl();
        Console.WriteLine();
        order4.DisplayShippingLbl();
        Console.WriteLine($"Total: ${order4.GetTotalCost()}");

    }
}