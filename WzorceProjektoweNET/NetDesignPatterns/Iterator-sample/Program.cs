// Build a collection of jelly beans
using Iterator_sample;

JellyBeanCollection collection = new JellyBeanCollection();
collection[0] = new JellyBean("Cherry");
collection[1] = new JellyBean("Bubble Gum");
collection[2] = new JellyBean("Root Beer");
collection[3] = new JellyBean("French Vanilla");
collection[4] = new JellyBean("Licorice");
collection[5] = new JellyBean("Buttered Popcorn");
collection[6] = new JellyBean("Juicy Pear");
collection[7] = new JellyBean("Cinnamon");
collection[8] = new JellyBean("Coconut");

// Create iterator
JellyBeanIterator iterator = collection.CreateIterator();

Console.WriteLine("Gimme all the jelly beans!");

for (JellyBean item = iterator.First();
    !iterator.IsDone; item = iterator.Next())
{
    Console.WriteLine(item.Flavor);
}

Console.ReadKey();