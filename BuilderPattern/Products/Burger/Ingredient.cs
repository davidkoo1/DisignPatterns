using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Products.Burger
{
    public class Ingredient
    {
        public string IngredientsName { get; set; }
        public decimal IngredientsPrice { get; set; }
        /*        public override string ToString()
                {
                    return $"{IngredientsName} - {IngredientsPrice} $";
                }*/
    }
}
