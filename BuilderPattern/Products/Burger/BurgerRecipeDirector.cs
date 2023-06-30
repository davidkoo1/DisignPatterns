namespace BuilderPattern.Products.Burger
{
    public class BurgerRecipeDirector
    {
        private readonly IBurgerRecipeBuilder _builder;

        public BurgerRecipeDirector(IBurgerRecipeBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.BurgerName().WithCheese().WithCheese().WithBacon().TotalPrice();

        }
    }
}
