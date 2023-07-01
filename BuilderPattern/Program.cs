//Пораждающий шаблон -> создание новых объектов максимально удобно
//Задача пошаговая создание сложного объекта
//Конструкторы, которые не оч - называют телескопическими
//Fluent Builder

using BuilderPattern.Factories;
using BuilderPattern.Products;
using BuilderPattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(">>> Welcome to CodeCoffe Club <<<\n");
            List<IOrderItem> orders = new List<IOrderItem>();
            while (true)
            {
                Console.WriteLine("> Enter the type of product you would like to order:");
                Console.WriteLine("> 0 - Show final price");
                Console.WriteLine("> B - Burger");
                Console.WriteLine("> D - Drink");
                Console.WriteLine("> F - French Fries");
                Console.WriteLine("> * - Doping");

                //по ебалу бесплатно

                
                string orderType = Console.ReadLine();
                if (orderType == "0") break;
                else
                {
                    OrderItemFactory factory = GetFactory(orderType);

                    IOrderItem order = factory.GetOrder();

                    Console.WriteLine("\n> Order you've just created \n");
                    //Console.WriteLine(order);

                    orders.Add(order);
                }
            }
            IOrder orderPlace = null;
            while (true)
            {
                Console.WriteLine("Select where you want see you order");
                Console.WriteLine("\t> W - With You");
                Console.WriteLine("\t> S - Stay in coffeClub");

                string selectOrderPlace = Console.ReadLine().ToLower();

                if(selectOrderPlace == "w" || selectOrderPlace == "s")
                {
                    orderPlace = GetOrderPlace(selectOrderPlace);
                    break;
                }
            }

            var builder = new OrderBuilder(orders, orderPlace);

            var director = new OrderDirector(builder);

            director.Build();

            var report = builder.GetOrder();

            Console.WriteLine(report);

            builder.SelectPlace();
        }

        private static OrderItemFactory GetFactory(string orderType) =>
            orderType.ToLower() switch
            {
                "b" => new BurgerFactory("Fast Burger for you my friend! "),
                "d" => new DrinkFactory(),
                "f" => new FrenchFriesFactory(10m, "Hot potate"),
                "*" => new DopingFactory(),
                _ => null
            };

        private static IOrder GetOrderPlace(string orderPlace) =>
            orderPlace.ToLower() switch
            {
                "w" => new WithUser(),
                "s" => new InCoffeClub(),
                _ => null
            };
    
    }
}
