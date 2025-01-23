using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSystemInterface
{
    internal class ConsoleInterface : IUserInterface
    {
        void IUserInterface.DisplayMenu()
        {
            Console.WriteLine("Jaka smutna konsola :(");
        }
    }
}
