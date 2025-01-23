using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClausFactory
{
    internal class Gift
    {
        internal string Name { get; set; }
        internal bool ForNiceChildren { get; set; }
        internal Gift(string name)
        {
            Name = name;
        }
    }
}
