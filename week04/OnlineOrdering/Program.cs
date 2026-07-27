using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Chocolate", 1, 2.89, 4);
        Product product2 = new Product("Ice Cream", 2, 3.99, 2);
        Product product3 = new Product("Soda", 3, 1.99, 3);
        Customer customer = new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "USA"));
        Order order1 = new Order(customer);
        
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Product product4 = new Product("Cookies", 4, 1.99, 4);
        Product product5 = new Product("Chips", 5, 0.99, 5);
        Customer customer2 = new Customer("Jane Doe", new Address("456 Main St", "Anytown", "TN", "CAN"));
        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);


        foreach (Order order in orders)
        {
            Console.WriteLine($"Shipping cost: {order.GetShippingCost()} USD");
            Console.WriteLine($"Packing label: {order.GetPackingLabel()}");
            Console.WriteLine($"Shipping label: {order.GetShippingLabel()}");
            Console.WriteLine($"Total price: {order.GetTotalPrice()} USD");
            Console.WriteLine("--------------------------------");
        }
    }
}