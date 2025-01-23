using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClausFactory
{
    internal class Rod : Gift
    {
        internal Rod(string name) : base(name)
        {
            ForNiceChildren = false; 
        }
    }
}
