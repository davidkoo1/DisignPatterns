using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Время заказа
//Название бургера
//Задействованные ингредиенты + *цена на каждый
//общая цена на бургер
//общая цена заказа
namespace BuilderPattern.Products.Burger
{
    public class BurgerRecipeBuilder : IBurgerRecipeBuilder
    {
        private BurgerRecipe _burgerRecipe;

        public BurgerRecipeBuilder()
        {
            _burgerRecipe = new();
        }

        public IBurgerRecipeBuilder BurgerName()
        {
            Console.WriteLine("Write new name burger");
            _burgerRecipe.Name = Console.ReadLine();

            return this;
        }
        public IBurgerRecipeBuilder WithCheese()
        {
            Ingredient ingredient = new Ingredient();
            ingredient.IngredientsName = "Сыр";
            ingredient.IngredientsPrice = 12.3m;
            _burgerRecipe.Ingredients.Add(ingredient);

            return this;
        }
        public IBurgerRecipeBuilder WithBacon()
        {
            _burgerRecipe.Ingredients.Add(new Ingredient { IngredientsName = "Бикон", IngredientsPrice = 10.2m });
            return this;
        }

        public IBurgerRecipeBuilder WithPickles()
        {
            _burgerRecipe.Ingredients.Add(new Ingredient { IngredientsName = "Огурчик", IngredientsPrice = 2.1m });
            return this;
        }

        public IBurgerRecipeBuilder WithLettuce()
        {
            _burgerRecipe.Ingredients.Add(new Ingredient { IngredientsName = "Лук", IngredientsPrice = 100 });
            return this;
        }

        public IBurgerRecipeBuilder WithTomato()
        {
            _burgerRecipe.Ingredients.Add(new Ingredient { IngredientsName = "Помидор", IngredientsPrice = 9.5m });
            return this;
        }

        public IBurgerRecipeBuilder TotalPrice()
        {
            _burgerRecipe.GetPrice();


            return this;
        }
        public BurgerRecipe GetBurger()
        {
            BurgerRecipe burgerRecipe = _burgerRecipe;

            _burgerRecipe = new();

            return burgerRecipe;
        }
    }
}
