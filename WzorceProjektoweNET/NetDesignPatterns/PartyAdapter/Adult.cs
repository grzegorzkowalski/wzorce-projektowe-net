using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyAdapter
{
    internal class Adult : Client
    {
        public Adult(string name, int age) : base(name, age)
        {
        }
    }
}
