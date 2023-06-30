using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Products.Drink
{
    public interface IDrinkBuilder
    {
        void Cola();

        void Sprite();

        void Fanta();

        void SimpleWater();

        Drink GetDrink();
    }
}
