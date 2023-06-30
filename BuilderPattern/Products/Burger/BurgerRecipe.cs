using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BuilderPattern.Products.Burger
{
    public class BurgerRecipe : IOrderItem
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public decimal GetPrice() => Ingredients.Sum(x => x.IngredientsPrice);

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(Name);
            stringBuilder.AppendLine("\t\t" + Description);
            stringBuilder.AppendLine("-----------------------------------------------------------------------------------");

            var result = from ingredient in Ingredients
                         group ingredient by ingredient.IngredientsName into g
                         select new { IngredientName = g.Key, IngredientCount = g.Count(), IngredientPrice = g.FirstOrDefault().IngredientsPrice };

            foreach (var current in result)
                stringBuilder.AppendLine($"{current.IngredientName} | {current.IngredientCount} | {current.IngredientPrice}$ - for one");

            stringBuilder.AppendLine("-----------------------------------------------------------------------------------");
            stringBuilder.AppendLine($"\t\tPrice: {Convert.ToString(GetPrice())}$");

            return stringBuilder.ToString();
        }

        // public override string ToString() => new StringBuilder().Append(BurgerName).Append(string.Join(Environment.NewLine, Ingredients)).Append(Price).ToString();
    }
}
