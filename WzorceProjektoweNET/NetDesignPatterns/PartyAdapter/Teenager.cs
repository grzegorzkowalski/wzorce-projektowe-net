namespace PartyAdapter
{
    internal class Teenager
    {
        public string Name { get; }
        public Teenager(string name)
        {
            Name = name;
        }

        public virtual void letsParty()
        {
            Console.WriteLine("Poproszę redbulla");
        }
    }
}
