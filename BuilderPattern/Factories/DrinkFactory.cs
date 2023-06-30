using BuilderPattern.Products.Burger;
using BuilderPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Products.Drink;

namespace BuilderPattern.Factories
{
    public class DrinkFactory : OrderItemFactory
    {

        public override IOrderItem GetOrder()
        {


            var drinkBuilder = new DrinkBuilder();
            //while (true)
          //  {
                Console.WriteLine("Select drink: ");
               // Console.WriteLine("0 - Print final price");
                Console.WriteLine("1 - Cola: ");
                Console.WriteLine("2 - Sprite: ");
                Console.WriteLine("3 - Fanta: ");
                Console.WriteLine("4 - Simple water: ");
                Console.WriteLine("5 - Baban: ");

                int optionsForDrink = int.Parse(Console.ReadLine());

               // if (optionsForDrink == 0) break;
                switch (optionsForDrink)
                {
                    case 1: drinkBuilder.Cola(); break;
                    case 2: drinkBuilder.Sprite(); break;
                    case 3: drinkBuilder.Fanta(); break;
                    case 4: drinkBuilder.SimpleWater(); break;
                    case 5: drinkBuilder.Baban(); break;
                }
           // }

            var tmp = drinkBuilder.GetDrink();


            return tmp;
        }
    }
}
