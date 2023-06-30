using BuilderPattern.Products;
using BuilderPattern.Products.Drink;
using BuilderPattern.Products.FrenchFries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Factories
{
    public class FrenchFriesFactory : OrderItemFactory
    {

        private readonly decimal _price;
        private string _description;

        public FrenchFriesFactory(decimal price, string descripcion)
        {
            _price = price;
            _description = descripcion;

        }

        public override IOrderItem GetOrder()
        {

            var frenchFriesBuilder = new FrenchFriesBuilder(_price);
 
            Console.WriteLine("Select what you want");
            Console.WriteLine("0 - Skip");
            Console.WriteLine("1 - Sauce");
            Console.WriteLine("2 - Spices");
            int frenchFriesDopingOption = int.Parse(Console.ReadLine());
            if(frenchFriesDopingOption == 1 || frenchFriesDopingOption == 2)
            switch(frenchFriesDopingOption)
            {
                case 1: frenchFriesBuilder.WithSauce(); break;
                case 2: frenchFriesBuilder.WithSpices(); break;
            }

            var tmp = frenchFriesBuilder.GetFrenchFries();

            FrenchFries frenchFries = new(_price)
            {
                Description = _description,
                Doppings = tmp.Doppings
            };

            return frenchFries;
        }

    }
}
