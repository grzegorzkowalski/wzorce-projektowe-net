using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyAdapter
{
    internal class Teenager
    {
        public string Name { get; }
        public Teenager(string name)
        {
            Name = name;
        }

        public virtual void letsParty()
        {
            Console.WriteLine("Poproszę redbulla");
        }
    }
}
