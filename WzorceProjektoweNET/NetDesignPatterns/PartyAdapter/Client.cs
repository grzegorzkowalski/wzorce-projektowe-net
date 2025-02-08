namespace PartyAdapter
{
    internal abstract class Client
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Client(string name, int age) 
        { 
            Name = name;
            Age = age;  
        }
        public virtual bool checkIsAdult()
        {
            return Age >= 18;
        }

        public virtual void letsParty()
        {
            Console.WriteLine("Poproszę wódkę z colą");
        }

    }
}
