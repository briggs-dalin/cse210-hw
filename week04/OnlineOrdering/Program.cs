using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       //Order 1 
       Address address1 = new Address("Furugränden 8, Lgh. 658", "Kramlöv", "Västerbotten" , "Sweden");
       Customer cusomter1 = new Customer("Andreas Fransson", address1);
       List<Product> productsList1 = new List<Product>();

       Product p1001 = new Product("Michael Kors Oversized Slim Runway Men's Watch", "MW100", 105.98, 1);
       Product p2002 = new Product("Sailwind Men's Crewneck Sweater Soft Casual Sweater", "MS607", 29.98, 1);
       Product p3031 = new Product("Duracell Coppertop AA Batteries, 24 Count Pack", "BA246", 17.99, 3);

        productsList1.Add(p1001);
        productsList1.Add(p2002);
        productsList1.Add(p3031);

        Order order1 = new Order(productsList1, cusomter1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();


       //Order 2
       Address address2 = new Address("134 S 2500 E", "Medford", "Oregon", "USA");
       Customer cusomter2 = new Customer("Madison C. Gooding", address2);
       List<Product> productsList2 = new List<Product>();

       Product p1004 = new Product("ONO Roller - Handheld Fidget Toy for Adults", "OR123", 28.00, 2);
       Product p2006 = new Product("BOSTANTEN Crossbody Bags for Women ", "WP201", 39.99, 1);
       Product p9081 = new Product("All in One Makeup Kit for Women Full Kit", "MK865", 26.99, 1);

        productsList2.Add(p1004);
        productsList2.Add(p2006);
        productsList2.Add(p9081);

        Order order2 = new Order(productsList2, cusomter2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        //Order 3
       Address address3 = new Address("276 Reading Cir", "Declo", "Idaho" , "USA");
       Customer cusomter3 = new Customer("Fred Tillmer", address3);
       List<Product> productsList3 = new List<Product>();

       Product p3003 = new Product("PlayStation DualSense® Wireless Controller - White", "PC101", 74.99, 2);
       Product p4004 = new Product("Logitech G335 Wired Gaming Headset", "GH335", 47.99, 1);
       Product p5005 = new Product("PS5 Controller Charger Station for PlayStation 5 Dualsense Controllers", "CS764", 16.99, 1);

        productsList3.Add(p3003);
        productsList3.Add(p4004);
        productsList3.Add(p5005);

        Order order3 = new Order(productsList3, cusomter3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}