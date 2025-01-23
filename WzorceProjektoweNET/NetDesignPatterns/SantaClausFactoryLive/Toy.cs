using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClausFactoryLive
{
    internal class Toy : Gift
    {
        internal Toy(string name)
        {
            Name = name;
            ForNiceChildren = true;
        }

    }
}
