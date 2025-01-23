using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSystemInterface
{
    internal class GUIInterface : IUserInterface
    {
        void IUserInterface.DisplayMenu()
        {
            Console.WriteLine("Jakie ładne okienka");
        }
    }
}
