using WarriorFactory;

namespace WarriorBuilder
{
    internal abstract class WarriorBuilder
    {
        protected readonly string _name;
        protected readonly int _age;
        public WarriorBuilder(string name, int age)
        {
            _name = name;
            _age = age;

        }
        public IWarrior Warrior { get; set; }
        internal abstract void goToArmy();
        internal abstract void getWeapon();
        internal abstract IWarrior trainWithWeapon();

    }
}
