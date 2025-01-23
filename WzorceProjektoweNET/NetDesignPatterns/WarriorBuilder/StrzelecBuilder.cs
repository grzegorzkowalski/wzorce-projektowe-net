using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

namespace WarriorBuilder
{
    internal class StrzelecBuilder : WarriorBuilder
    {
        public StrzelecBuilder(string name, int age) : base(name, age)
        {
        }

        internal override void getWeapon()
        {
            Console.WriteLine(" Strzelec pobrał łuk");
        }

        internal override void goToArmy()
        {
            Console.WriteLine(" Strzelec wstapił do armii");
        }

        internal override IWarrior trainWithWeapon()
        {
            Console.WriteLine(" Strzelec jest gotowy do walki");
            return new Strzelec(_name, _age);
        }
    }
}
