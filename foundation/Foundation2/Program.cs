using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("1465 Wanamaker Rd", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Mishell Garcia", address1);
        Customer customer2 = new Customer("Hugo Reyes", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Oled Switch", "G093", 399.99m, 1));
        order1.AddProduct(new Product("Pro Controller", "C4930", 24.99m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Zelda Amiibo", "Z5948", 24.95m, 1));
        order2.AddProduct(new Product("Headphones", "H908", 84.99m, 1));

        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);


        static void DisplayOrderDetails(Order order)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine();
        }
    }

}