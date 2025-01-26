namespace SantaClausFactoryLive
{
    internal class CommandFactory
    {
        private readonly SantaFactory _factory;

        public CommandFactory(SantaFactory factory)
        {
            _factory = factory;
        }

        public ICommand GetCommand(int commandID, string giftName)
        {
            return commandID switch
            {
                1 => new CreateGiftCommand(_factory.CreateToy, giftName),
                2 => new CreateGiftCommand(_factory.CreateRod, giftName),
                _ => throw new ArgumentException("Nieprawidłowy typ komendy!")
            };
        }
    }
}
