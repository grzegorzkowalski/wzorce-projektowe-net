using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSystemInterface
{
    internal class SystemWindows
    {
        internal IUserInterface userInterface { get; set; }
        internal void DisplayMenu()
        {
            if (userInterface != null)
            {
                userInterface.DisplayMenu();
            }
        }
    }
}
