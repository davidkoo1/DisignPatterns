using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Products;
using BuilderPattern.Products.Burger;

namespace BuilderPattern.Factories
{
    public class BurgerFactory : OrderItemFactory
    {
        private readonly string _description;

        public BurgerFactory(string? descripcion)
        {
            _description = descripcion;
        }

        public override IOrderItem GetOrder()
        {


            var builder = new BurgerRecipeBuilder();
            builder.BurgerName();
            while (true)
            {
                Console.WriteLine("Select ingridient for u burger: ");
                Console.WriteLine("0 - Print final price");
                Console.WriteLine("1 - Cheese: ");
                Console.WriteLine("2 - Bacon: ");
                Console.WriteLine("3 - Pickles: ");
                Console.WriteLine("4 - Lettuce: ");
                Console.WriteLine("5 - Tomato: ");

                int optionsForBurger = int.Parse(Console.ReadLine());

                if (optionsForBurger == 0) break;
                switch (optionsForBurger)
                {
                    case 1: builder.WithCheese(); break;
                    case 2: builder.WithBacon(); break;
                    case 3: builder.WithPickles(); break;
                    case 4: builder.WithLettuce(); break;
                    case 5: builder.WithTomato(); break;
                }
            }

            builder.TotalPrice();
            var tmp = builder.GetBurger();

            BurgerRecipe order = new()
            {
                Name = tmp.Name,
                Ingredients = tmp.Ingredients,
                Description = _description
            };

            return order;

        }
    }
}
