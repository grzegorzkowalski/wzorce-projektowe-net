using WarriorFactory;

var garnizon = new Garnizon();
List<IWarrior> warriors = new();

Tuple<string, string, int>[] orders = {
    new Tuple <string, string, int>("piechur", "Steve", 18),
    new Tuple <string, string, int>("piechur", "Steve", 19),
    new Tuple <string, string, int>("piechur", "Steve", 20),
    new Tuple <string, string, int>("konny", "Jobs", 21),
    new Tuple <string, string, int>("konny", "Jobs", 22),
    new Tuple <string, string, int>("konny", "Jobs", 23),
    new Tuple <string, string, int>("strzelec", "Steve", 24),
    new Tuple <string, string, int>("strzelec", "Steve", 25),
    new Tuple <string, string, int>("strzelec", "Steve", 26),
    new Tuple <string, string, int>("strzelec", "Steve", 27), 
};

foreach (var item in orders)
{
    warriors.Add(garnizon.createSoldier(item.Item1, item.Item2, item.Item3));
}

foreach (var item in warriors)
{
    Console.WriteLine($"Cześć mam na imię {item.Name} i moja specjalność to {item.GetType()}");
}

