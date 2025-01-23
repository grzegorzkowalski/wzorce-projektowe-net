using FactoryMethod_sample;

List<Sandwich> sandwiches = new List<Sandwich>();
sandwiches.Add(new TurkeySandwich());
sandwiches.Add(new Dagwood());

foreach (var sandwich in sandwiches)
{
    Console.WriteLine("\nSandwich: " + sandwich.GetType().Name + " ");
    foreach (var ingredient in sandwich.Ingredients)
    {
        Console.WriteLine("Ingredient: " + ingredient.GetType().Name);
    }
}

Console.ReadKey();