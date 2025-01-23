using WarriorBuilder;
using WarriorFactory;

var pB = new PiechurBuilder("Jan", 18);
var post = new WarriorPost(pB);
Console.WriteLine(post.warrior.GetType());

var pK = new KonnyBuilder("Tomasz", 20);
var post2 = new WarriorPost(pK);
Console.WriteLine(post2.warrior.GetType());

var pS = new StrzelecBuilder("Mateusz", 24);
var post3 = new WarriorPost(pS);
Console.WriteLine(post3.warrior.GetType());

List<IWarrior> nowaArmia = new();

nowaArmia.Add(post.warrior);
nowaArmia.Add(post2.warrior);
nowaArmia.Add(post3.warrior);

foreach (var item in nowaArmia)
{
    Console.WriteLine($"Cześć mam na imię {item.Name} i moja specjalność to {item.GetType()}");
}
