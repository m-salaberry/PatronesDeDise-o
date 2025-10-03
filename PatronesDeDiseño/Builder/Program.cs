namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PizzaBuilder> builders = new List<PizzaBuilder>();
            builders.Add(new PizzaItalianaBuilder());
            builders.Add(new PizzaMuzzarelaBuilder());
            builders.Add(new PizzaLightBuilder());

            foreach (var builder in builders)
            {
                Pizza pizza = builder.BuildPizza();
                Console.WriteLine(pizza);
            }
        }
    }
}