using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("3157 Farnam St", "Omaha", "NE 68031", "USA");
        Customer drElwood = new Customer("Shannon Elwood", address);
        Product cooperVision = new Product("FreshDay 90pk", "CV8442", 70, 8);
        Product acuvue = new Product("Acuvue Oasys 24pk", "AC7846", 150, 2);
        Product alcon = new Product("Precision 7 27pk", "AL1649", 105, 4);
        Order order = new Order(drElwood);
        order.AddProduct(cooperVision);
        order.AddProduct(acuvue);
        order.AddProduct(alcon);
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel() + "\n");
        Console.WriteLine(order.DisplayShippingCost());
        Console.WriteLine(order.GetTotalCost() + "\n");
        
        Address address2 = new Address("Rua Uruguai, 905", "Passo Fundo", "RS 99010-110", "Brazil");
        Customer brunoSoares = new Customer("Bruno Soares", address2);
        Product box = new Product("White box", "BX1122", 23, 10);
        Product tie = new Product("Emerald green tie", "TE3355", 19, 7);
        Order order2 = new Order(brunoSoares);
        order2.AddProduct(box);
        order2.AddProduct(tie);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel() + "\n");
        Console.WriteLine(order2.DisplayShippingCost());
        Console.WriteLine(order2.GetTotalCost());
    }
}