using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

namespace WarriorBuilder
{
    internal class KonnyBuilder : WarriorBuilder
    {
        public KonnyBuilder(string name, int age) : base(name, age)
        {
        }

        internal override void getWeapon()
        {
            Console.WriteLine(" Konny pobrał lancę");
        }

        internal override void goToArmy()
        {
            Console.WriteLine(" Konny wstapił do armii");
        }

        internal override IWarrior trainWithWeapon()
        {
            Console.WriteLine(" Konny jest gotowy do walki");
            return new Konny(_name, _age);

        }
    }
}
