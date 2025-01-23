using AbstractFactory_sample;

Console.WriteLine("Who are you? (A)dult or (C)hild?");
char input = Console.ReadKey().KeyChar;
RecipeFactory factory;
switch (input)
{
    case 'A':
        factory = new AdultCuisineFactory();
        break;

    case 'C':
        factory = new KidCuisineFactory();
        break;

    default:
        throw new NotImplementedException();

}

var sandwich = factory.CreateSandwich();
var dessert = factory.CreateDessert();

Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
Console.WriteLine("Dessert: " + dessert.GetType().Name);

Console.ReadKey();