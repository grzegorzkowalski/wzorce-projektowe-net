namespace WarriorFactory
{
    public class Konny : IWarrior
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Weapon
        {
            get
            {
                return "lance";
            }
        }

        public Konny(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
