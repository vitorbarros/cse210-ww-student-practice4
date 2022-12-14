using System;
using System.Collections.Generic;
using Practice2.Models;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            var prod1 = new Product("iPhone", 1000, 1);
            var prod2 = new Product("Apple Watch", 200, 2);
            var prod3 = new Product("MacBook", 3000, 1);

            List<Product> prods = new List<Product>();
            prods.Add(prod1);
            prods.Add(prod2);
            prods.Add(prod3);

            var address1 = new Address("140th St", "USA");
            var customer1 = new Customer("Viror", address1);
            
            var address2 = new Address("140th St", "Brazil");
            var customer2 = new Customer("Viror", address2);
            
            var order1 = new Order(prods, customer1);
            var order2 = new Order(prods, customer2);

            List<Order> orders = new List<Order>();
            
            orders.Add(order1);
            orders.Add(order2);
            
            foreach (var order in orders)
            {
                Console.WriteLine("Order -> ShippingLabel: " + order.GetShippingLabel() + " TotalPrice: " + order.GetTotalCost());
                Console.WriteLine("PackingLabel: \n" + order.GetPackingLabel());

                foreach (var product in order.GetProducts())
                {
                    Console.WriteLine("     Product -> Name: " + product.GetName() + " Price: " + product.GetPrice() + " Quantity: " + product.GetQuantity());
                }
            }
        }
    }
}
