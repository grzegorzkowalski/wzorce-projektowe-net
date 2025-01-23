namespace WarriorFactory
{
    internal class Garnizon
    {      
        public IWarrior createSoldier(string type, string name, int age)
        {
            switch (type)
            {
                case "piechur":
                    {
                        return new Piechur(name, age);
                    }
                case "strzelec":
                    {
                        return new Strzelec(name, age);
                    }
                case "konny":
                    {
                        return new Konny(name, age);
                    }
                default:
                    {
                        return new Piechur(name, age);
                    }
            }
        }

    }
}
