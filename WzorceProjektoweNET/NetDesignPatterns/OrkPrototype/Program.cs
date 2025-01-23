using Newtonsoft.Json;
using OrkPrototype;

List<Ork> battleOrks = new();

var ork = new Ork();
ork.Age = 100;
ork.Strenght = 200;
ork.Speed = 50;

battleOrks.Add(ork);

Ork cloneOrk = ork.copyOrk();
Ork cloneOrk2 = ork.copyOrk();
battleOrks.Add(cloneOrk);
battleOrks.Add(cloneOrk2);
battleOrks.Add(ork.copyOrk());

foreach (var item in battleOrks)
{
    Console.WriteLine($"Cześć moja siła to {item.Strenght}, " +
        $"mój wiek to {item.Age}, moja szybkość to {item.Speed} {item.GetType()}");
}

