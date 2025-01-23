using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyAdapter
{
    internal class FakeAdult : Client
    {
        private Teenager teenager;
        public FakeAdult(string name, int age) : base(name, age)
        {
            teenager = new Teenager(name);
            Age = 18;
        }

        public override void letsParty()
        {
            teenager.letsParty();
        }
    }
}
