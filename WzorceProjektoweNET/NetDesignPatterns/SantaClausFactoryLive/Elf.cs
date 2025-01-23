using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClausFactoryLive
{
    internal interface ICommand
    {
        Gift Execute();
    }

    internal class CreateToyCommand : ICommand
    {
        private readonly SantaFactory _factory;
        private readonly string _toyName;

        public CreateToyCommand(SantaFactory factory, string toyName)
        {
            _factory = factory;
            _toyName = toyName;
        }

        public Gift Execute()
        {
            return _factory.CreateToy(_toyName);
        }
    }

    internal class CreateRodCommand : ICommand
    {
        private readonly SantaFactory _factory;
        private readonly string _rodName;

        public CreateRodCommand(SantaFactory factory, string rodName)
        {
            _factory = factory;
            _rodName = rodName;
        }

        public Gift Execute()
        {
            return _factory.CreateRod(_rodName);
        }
    }

    internal class Elf
    {
        private SantaFactory _factory = new();
        private List<ICommand> _commands = new List<ICommand>();
        private List<Gift> _gifts = new List<Gift>();

        internal void AddWish(int commandID, string giftName)
        {
            ICommand command;
            switch (commandID)
            {
                case 1:
                    command = new CreateToyCommand(_factory, giftName);
                    break;
                case 2:
                    command = new CreateRodCommand(_factory, giftName);
                    break;
                default:
                    command = new CreateToyCommand(_factory, giftName);
                    break;
            }

            _commands.Add(command);
        }

        internal void Execute()
        {
            _commands.ForEach(command =>
            {
                Gift gift = command.Execute();
                _gifts.Add(gift);
            });

            Console.WriteLine("Wszystkie prezenty przygotowane");
        }

        internal List<Gift> GetPreparedGifts()
        {
            return _gifts;
        }
    }
}
