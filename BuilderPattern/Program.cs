//Пораждающий шаблон -> создание новых объектов максимально удобно
//Задача пошаговая создание сложного объекта
//Конструкторы, которые не оч - называют телескопическими
//Fluent Builder

using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var builder = new BurgerRecipeBuilder();

            BurgerRecipe burger = new BurgerRecipe();
            builder.BurgerName();
            builder.WithBacon();
            builder.TotalPrice();
            var tmp = builder.GetBurger(); //попробовать без директора

            var director = new BurgerRecipeDirector(builder);

            // director.Build();

            var report = builder.GetBurger();

            Console.WriteLine(tmp);
        }
    }
}
