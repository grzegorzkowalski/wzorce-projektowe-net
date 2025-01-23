namespace WarriorFactory
{
    public interface IWarrior
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Weapon { get; }
    }
}
