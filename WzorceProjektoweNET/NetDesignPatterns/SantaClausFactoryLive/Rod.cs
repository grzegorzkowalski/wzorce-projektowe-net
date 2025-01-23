using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClausFactoryLive
{
    internal class Rod : Gift
    {
        internal Rod(string name)
        {

            Name = name;
            ForNiceChildren = false;
        }
    }
}
