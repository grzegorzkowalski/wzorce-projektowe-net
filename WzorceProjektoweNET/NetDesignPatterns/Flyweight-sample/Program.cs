// See htt// Build a slider order using patron's input
using Flyweight_sample;

Console.WriteLine("Please enter your slider order (use characters B, V, Q with no spaces):");
var order = Console.ReadLine();
char[] chars = order.ToCharArray();

SliderFactory factory = new SliderFactory();

int orderTotal = 0;

//Get the slider from the factory
foreach (char c in chars)
{
    orderTotal++;
    Slider character = factory.GetSlider(c);
    character.Display(orderTotal);
}

Console.ReadKey();