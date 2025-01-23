namespace WarriorFactory
{
    public class Strzelec : IWarrior
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Weapon
        {
            get
            {
                return "bow";
            }
        }

        public Strzelec(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
