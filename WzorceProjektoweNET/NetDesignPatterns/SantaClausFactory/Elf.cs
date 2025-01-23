using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClausFactory
{

    internal class Elf
    {
        private List<Gift> _gifts = new List<Gift>();
        private SantaClausFactory factory = new SantaClausFactory();
        public List<Tuple<int, string>> listOfCommands = new List<Tuple<int, string>>();

        public void AddCommand(int commandID, string toyName)
        {
            var order = new Tuple<int, string>(commandID, toyName);
            listOfCommands.Add(order);
        }

        public void Execute()
        {
            foreach (var item in listOfCommands)
            {
                _gifts.Add(factory.GetToy(item.Item1, item.Item2));
                Console.WriteLine(item.Item2);
            }
            
        }
    }
}
