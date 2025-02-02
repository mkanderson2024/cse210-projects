using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123", "Pinkerton St", "Snowflake", "AZ", "USA");
        Customer customer1 = new Customer("Jo Jo", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Modular Couch", 1010, 2500, 1),
            new Product("Projector", 2401, 2000, 1)
        };

        Order order1 = new Order(customer1, products1);

        Address address2 = new Address("456", "Braveery Rd", "Saskatoon", "SK", "CA");
        Customer customer2 = new Customer("Sarah Mackley", address2);
        List<Product> products2 = new List<Product>{
            new Product("Car", 12356, 25000, 1),
            new Product("Undercarrage Lights", 1515, 240, 2),
        };

        Order order2 = new Order(customer2, products2);

        //Order 1
        Console.WriteLine("--------Order 1--------");
        Console.WriteLine($"Total Cost: ${order1.CaculateCost()}");
        Console.WriteLine("------Packaging Label------\n");
        Console.WriteLine($"Packaging Label: {order1.ProducePackingLabel()}");
        Console.WriteLine("------Shipping Label-----\n");
        Console.WriteLine($"Shipping Label: {order1.ProduceShippingLabel()}\n");

        Console.WriteLine("--------Order 2--------");
        Console.WriteLine($"Total Cost: ${order2.CaculateCost()}");
        Console.WriteLine("------Packaging Label------\n");
        Console.WriteLine($"Packaging Label: {order2.ProducePackingLabel()}");
        Console.WriteLine("------Shipping Label-----\n");
        Console.WriteLine($"Shipping Label: {order2.ProduceShippingLabel()}\n");
    }
}