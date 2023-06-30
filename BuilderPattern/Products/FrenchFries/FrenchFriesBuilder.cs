using BuilderPattern.Factories;
using BuilderPattern.Products.Doping;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Products.FrenchFries
{
    public class FrenchFriesBuilder : IFrenchFriesBuilder
    {
        private readonly decimal _price;
        private FrenchFries _frenchFries;
        private DopingBuilder _dopingBuilder;
        public FrenchFriesBuilder(decimal price)
        {
            _price = price;
            _frenchFries = new(_price);
            _dopingBuilder = new();
        }

        public void WithSauce()
        {
            while (true)
            {
                Console.WriteLine("Select Sauce:");
                Console.WriteLine("1 - Ketchup");
                Console.WriteLine("2 - Onion");
                Console.WriteLine("3 - Adjika");
                Console.WriteLine("4 - Mustard");
                Console.WriteLine("5 - Mayonnaise");
                int optionSause = int.Parse(Console.ReadLine());
                if (optionSause == 0) break;
                switch (optionSause)
                {
                    case 1: _dopingBuilder.WithKetchup(); break;
                    case 2: _dopingBuilder.WithOnion(); break;
                    case 3: _dopingBuilder.WithAdjika(); break;
                    case 4: _dopingBuilder.WithMustard(); break;
                    case 5: _dopingBuilder.WithMayonnaise(); break;
                }
                var tmp = _dopingBuilder.GetDoping();
                _frenchFries.Doppings.Add(tmp);
            }
        }

        public void WithSpices()
        {
            while (true)
            {
                Console.WriteLine("Select Sauce:");
                Console.WriteLine("1 - Salt");
                Console.WriteLine("2 - Pepper");
                Console.WriteLine("3 - Verdure");

                int optionSpices = int.Parse(Console.ReadLine());
                if (optionSpices == 0) break;
                switch (optionSpices)
                {
                    case 1: _dopingBuilder.WithSalt(); break;
                    case 2: _dopingBuilder.WithPepper(); break;
                    case 3: _dopingBuilder.WithVerdure(); break;
                }
                var tmp = _dopingBuilder.GetDoping();
                _frenchFries.Doppings.Add(tmp);
            }
        }

        public FrenchFries GetFrenchFries()
        {
            FrenchFries frenchFries = _frenchFries;

            _frenchFries = new(_price);

            return frenchFries; 
        }
    }
}
