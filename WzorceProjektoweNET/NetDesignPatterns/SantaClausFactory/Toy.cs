using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClausFactory
{
    internal class Toy : Gift
    {
        internal Toy(string name) : base(name)
        {
            ForNiceChildren = true;
        }
    }
}
