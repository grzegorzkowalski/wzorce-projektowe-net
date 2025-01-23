using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

namespace WarriorBuilder
{
    internal class PiechurBuilder : WarriorBuilder
    {
        public PiechurBuilder(string name, int age) : base(name, age)
        {
        }

        internal override void getWeapon()
        {
            Console.WriteLine(" Piechur pobrał miecz");
        }

        internal override void goToArmy()
        {
            Console.WriteLine(" Piechur wstapił do armii");
        }

        internal override IWarrior trainWithWeapon()
        {
            Console.WriteLine(" Piechur jest gotowy do walki");
            return new Piechur(_name, _age);
        }
    }
}
