using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BuilderPattern
{
    public class BurgerRecipe
    {
        public string BurgerName { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public string Price { get; set; }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(BurgerName);

            var result = from ingredient in Ingredients
                         group ingredient by ingredient.IngredientsName into g
                         select new { IngredientName = g.Key, IngredientCount = g.Count(), IngredientPrice = g.FirstOrDefault().IngredientsPrice };

            foreach (var current in result)
                stringBuilder.AppendLine($"{current.IngredientName} | {current.IngredientCount} | {current.IngredientPrice}$ - for one");

            stringBuilder.AppendLine(Price);

            return stringBuilder.ToString();
        }

        // public override string ToString() => new StringBuilder().Append(BurgerName).Append(string.Join(Environment.NewLine, Ingredients)).Append(Price).ToString();
    }
}
