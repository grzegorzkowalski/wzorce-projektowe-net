namespace WarriorFactory
{
    public class Piechur : IWarrior
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Weapon 
        { 
            get 
            {
                return "sword"; 
            } 
        }

        public Piechur(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
