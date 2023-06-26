namespace BuilderPattern
{
    public interface IBurgerRecipeBuilder
    {
        IBurgerRecipeBuilder BurgerName();
        IBurgerRecipeBuilder WithCheese();

        IBurgerRecipeBuilder WithBacon();

        IBurgerRecipeBuilder WithPickles();

        IBurgerRecipeBuilder WithLettuce();

        IBurgerRecipeBuilder WithTomato();

        IBurgerRecipeBuilder TotalPrice();

        BurgerRecipe GetBurger();
    }
}
