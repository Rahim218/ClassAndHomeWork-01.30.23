using ClassAndHomeWork_01._30._23.Classes;
using System;

namespace ClassAndHomeWork_01._30._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Product product = new Product();
            product.Name = "Zaa";
            Console.WriteLine(product.Name);
            product.Price = 10;
            Console.WriteLine(product.Price);
            Drink drink = new Drink();
            drink.Price = 2;
            Console.WriteLine(drink.Price);
            drink.AlcoholPercent = 10;
            Console.WriteLine(drink.AlcoholPercent);
            Car car = new Car(80);
            

        }
    }
}
