namespace SantaClausFactoryLive
{
    internal interface ICommand
    {
        Gift Execute();
        void Undo();
    }

    internal class CreateGiftCommand : ICommand
    {
        private readonly Func<string, Gift> _createGiftMethod;
        private readonly string _giftName;
        private Gift _createdGift;

        public CreateGiftCommand(Func<string, Gift> createGiftMethod, string giftName)
        {
            _createGiftMethod = createGiftMethod;
            _giftName = giftName;
        }

        public Gift Execute()
        {
            _createdGift = _createGiftMethod(_giftName);
            return _createdGift;
        }

        public void Undo()
        {
            Console.WriteLine($"Cofnięto przygotowanie prezentu: {_createdGift.Name}");
            _createdGift = null; // Możesz dodać logikę do faktycznego cofania.
        }
    }

    internal class Elf
    {
        private readonly List<ICommand> _commands = new();
        private readonly List<Gift> _gifts = new();
        private readonly SantaFactory _factory = new();

        internal void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void SetCommand(int commandOption, string name)
        {
            _commands.Add(new CommandFactory(_factory).GetCommand(commandOption, name));
        }

        internal void ExecuteAll()
        {
            _commands.ForEach(command =>
            {
                Gift gift = command.Execute();
                _gifts.Add(gift);
            });

            Console.WriteLine("Wszystkie prezenty przygotowane!");
        }

        internal void UndoLastCommand()
        {
            if (_commands.Count > 0)
            {
                var lastCommand = _commands[^1];
                lastCommand.Undo();
                _commands.RemoveAt(_commands.Count - 1);
            }
            else
            {
                Console.WriteLine("Brak komend do cofnięcia!");
            }
        }

        internal List<Gift> GetPreparedGifts() => _gifts;
    }
}
