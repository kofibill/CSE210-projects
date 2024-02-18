using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("Poppy Street No.15", "Abokobi-Boi", "Accra", "Ghana");
        Customer customer1 = new Customer("Fordson Kwesi Neymasem", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1 = new Product("Ford Raptor", "FR200", 77.99, 1);
        Product p2 = new Product("Laptop", "L50", 50.5, 5);
        Product p3 = new Product("Pencils", "P05", 2.99, 10);

        productsList1.Add(p1);
        productsList1.Add(p2);
        productsList1.Add(p3);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("Burma Camp St 220", "Burma City", "Accra", "Ghana");
        Customer customer2 = new Customer("Patterson Lamptey", address2);
        List<Product> productsList2 = new List<Product>();

        Product p01 = new Product("Assault Rifle", "AR221", 90.9, 2);
        Product p02 = new Product("Silencer", "S100", 5.75, 1);
        Product p03 = new Product("Magazine", "MG1000", 12.50, 4);

        productsList2.Add(p01);
        productsList2.Add(p02);
        productsList2.Add(p03);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("2010 W 500 S", "Salt Lake", "UT 84104", "USA");
        Customer customer3 = new Customer("Russell M. Nelson", address3);
        List<Product> productsList3 = new List<Product>();

        Product p11 = new Product("Pencil Case", "PC100", 8.99, 2);
        Product p12 = new Product("Highlighter Set", "HLSET", 4.99, 4);

        productsList3.Add(p11);
        productsList3.Add(p12);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}