using WarriorFactory;

namespace WarriorBuilder
{
    internal class WarriorPost
    {
        public IWarrior warrior;
        public WarriorPost(WarriorBuilder warriorBuilder)
        {
            warriorBuilder.goToArmy();
            warriorBuilder.getWeapon();
            warrior = warriorBuilder.trainWithWeapon();

        }
    }
}
