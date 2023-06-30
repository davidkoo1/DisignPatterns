using BuilderPattern.Products.Burger;
using BuilderPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Products.Doping;

namespace BuilderPattern.Factories
{
    public class DopingFactory : OrderItemFactory
    {

        public override IOrderItem GetOrder()
        {


            var builder = new DopingBuilder();
            Console.WriteLine("Select doping: ");
            Console.WriteLine("1 - Ketchup: ");
            Console.WriteLine("2 - Onion: ");
            Console.WriteLine("3 - Adjika: ");
            Console.WriteLine("4 - Mustard: ");
            Console.WriteLine("5 - Mayonnaise: ");
            Console.WriteLine("6 - Salt: ");
            Console.WriteLine("7 - Pepper: ");
            Console.WriteLine("8 - Verdure: ");

            int optionsForBurger = int.Parse(Console.ReadLine());

            switch (optionsForBurger)
            {
                case 1: builder.WithKetchup(); break;
                case 2: builder.WithOnion(); break;
                case 3: builder.WithAdjika(); break;
                case 4: builder.WithMustard(); break;
                case 5: builder.WithMayonnaise(); break;
                case 6: builder.WithSalt(); break;
                case 7: builder.WithPepper(); break;
                case 8: builder.WithVerdure(); break;
            }


            var tmp = builder.GetDoping();

            return tmp;

        }
    }
}
