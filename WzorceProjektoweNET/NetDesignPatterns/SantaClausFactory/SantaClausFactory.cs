using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClausFactory
{
    internal class SantaClausFactory
    {
        public Gift GetToy(int commandID, string toyName)
        {
            switch (commandID)
            {
                case 1:
                    return new Toy(toyName);
                case 2:
                    return new Rod(toyName);
                default:
                    return new Toy(toyName);
            }
        }
    }
}
