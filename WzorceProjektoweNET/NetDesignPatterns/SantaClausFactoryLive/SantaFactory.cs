namespace SantaClausFactoryLive
{
    internal class SantaFactory
    {
        public Gift CreateToy(string toyName)
        {
            Console.WriteLine($"Tworzenie zabawki: {toyName}");
            return new Gift { Name = toyName, Type = "Toy" };
        }

        public Gift CreateRod(string rodName)
        {
            Console.WriteLine($"Tworzenie rózgi: {rodName}");
            return new Gift { Name = rodName, Type = "Rod" };
        }
    }
}
