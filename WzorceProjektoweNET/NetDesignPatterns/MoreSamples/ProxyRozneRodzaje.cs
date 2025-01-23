//Rozdział 13.
//Pełnomocnik

//Pełnomocnik zabezpieczający

public class Car // : ICar
{
    public void Drive()
    {
        WriteLine("Ktoś mną kieruje");
    }
}

public interface ICar
{
    void Drive();
}

public class Driver
{
    public int Age { get; set; }
    public Driver(int age)
    {
        Age = age;
    }
}

public class CarProxy : ICar
{
    private Car car = new Car();
    private Driver driver;
    public CarProxy(Driver driver)
    {
        this.driver = driver;
    }
    public void Drive()
    {
        if (driver.Age >= 16)
            car.Drive();
        else
        {
            WriteLine("Kierowca jest za młody");
        }
    }
}
ICar car = new CarProxy(new Driver(12));
car.Drive(); // Kierowca jest za młody

// Pełnomocnik właściwości
public class Property<T> where T : new()
{
    private T value;
    private readonly string name;
    public T Value
    {
        get => value;
        set
        {
            if (Equals(this.value, value)) return;
            Console.WriteLine($"Przypisanie {value} do właściwości {name}");
            this.value = value;
        }
    }
    public Property() : this(default(T)) {}
    public Property(T value, string name = "")
    {
        this.value = value;
        this.name = name;
    }
}

public static implicit operator T(Property<T> property)
{
    return property.Value; // int n = p_int;
}

public static implicit operator Property<T>(T value)
{
    return new Property<T>(value); // Property<int> p = 123;
}

public class Creature
{
    public Property<int> Agility
        = new Property<int>(10, nameof(Agility))
}

var c = new Creature();
c.Agility = 12; // <nothing happens!>

public class Creature
{
    public readonly Property<int> agility
        = new Property<int>(10, nameof(agility));
    public int Agility
    {
        get => agility.Value;
        set => agility.Value = value;
    }
}

var c = new Creature();
c.Agility = 12; // Przypisanie 12 do Agility

//Pełnomocnik wartości
[DebuggerDisplay("{value*100.0f}%")]
public struct Percentage
{
    private readonly decimal value;
    internal Percentage(decimal value)
    {
        this.value = value;
    }
    // tutaj więcej składowych
}

public static class PercentageExtensions
{
    public static Percentage Percent(this int value)
    {
        return new Percentage(value / 100.0m);
    }
    public static Percentage Percent(this decimal value)
    {
        return new Percentage(value / 100.0m);
    }
}

public static decimal operator *(decimal f, Percentage p)
{
    return f * p.value;
}

public static Percentage operator +(Percentage a, Percentage b)
{
    return new Percentage(a.value + b.value);
}

public override string ToString()
{
    return $"{value * 100}%";
}

Console.WriteLine(10m * 5.Percent()); // 0.50
Console.WriteLine(2.Percent() + 3m.Percent()); // 5.00%

//Pełnomocnik kompozytu: SoA/AoS
class Creature
{
    public byte Age;
    public int X, Y;
}

class Creatures
{
    private readonly int size;
    private byte[] age;
    private int[] x, y;
    public Creatures(int size)
    {
        this.size = size;
        age = new byte[size];
        x = new int[size];
        y = new int[size];
    }
}

public struct Creature
{
    private readonly Creatures creatures;
    private readonly int index;
    public Creature(Creatures creatures, int index)
    {
        this.creatures = creatures;
        this.index = index;
    }
    public ref byte Age => ref creatures.age[index];
    public ref int X => ref creatures.x[index];
    public ref int Y => ref creatures.y[index];
}

public class Creatures
{
    // tutaj inne składowe
    public Creature this[int index]
    => new Creature(this, index);
    public IEnumerator<Creature> GetEnumerator()
    {
        for (int pos = 0; pos < size; ++pos)
            yield return new Creature(this, pos);
    }
}

// AoS
var creatures = new Creature[100];
foreach (var c in creatures)
{
    c.X++; // niewydajne jeśli chodzi o zarządzanie pamięcią
}
// SoA
var creatures2 = new Creatures(100);
foreach (var c in creatures2)
{
    c.X++;
}

//Pełnomocnik kompozytu z właściwościami przechowywanymi w tablicy
public class MasonrySettings
{
    public bool Pillars, Walls, Floors;
    public bool All
    {
        get { return Pillars && Walls && Floors; }
        set
        {
            Pillars = value;
            Walls = value;
            Floors = value;
        }
    }
}

public class MasonrySettings
{
    private bool[] flags = new bool[3];
    public bool Pillars
    {
        get => flags[0];
        set => flags[0] = value;
    }
    // podobnie dla Floors i Walls
}

public bool? All
{
    get
    {
        if (flags.Skip(1).All(f => f == flags[0]))
            return flags[0];
        return null;
    }
    set
    {
        if (!value.HasValue) return;
        for (int i = 0; i < flags.Length; ++i)
            flags[i] = value.Value;
    }
}



// Pełnomocnik wirtualny

interface IImage
{
    void Draw();
}

class Bitmap : IImage
{
    private readonly string filename;
    public Bitmap(string filename)
    {
        this.filename = filename;
        WriteLine($"Ładowanie obrazu z {filename}");
    }
    public void Draw()
    {
        WriteLine($"Rysowanie obrazu {filename}");
    }
}

var img = new Bitmap("pokemon.png");
// Ładowanie obrazu z pokemon.png
 class LazyBitmap : IImage
{
    private readonly string filename;
    private Bitmap bitmap;
    public LazyBitmap(string filename)
    {
        this.filename = filename;
    }
    public void Draw()
    {
        if (bitmap == null)
            bitmap = new Bitmap(filename);
        bitmap.Draw();
    }
}

public static void DrawImage(IImage img)
{
    WriteLine("Zamierzam narysować obraz");
    img.Draw();
    WriteLine("Zakończyłem rysowanie obrazu");
}

var img = new LazyBitmap("pokemon.png");
DrawImage(img); // tutaj zostanie załadowany obraz
// Zamierzam narysować obraz
// Ładowanie obrazu z pokemon.png
// Rysowanie obrazu pokemon.png
// Zakończyłem rysowanie obrazu




//Pełnomocnik komunikacji
interface IPingable
{
    string Ping(string message);
}

class Pong : IPingable
{
    public string Ping(string message)
    {
        return message + "pong";
    }
}

void UseIt(IPingable pp)
{
    WriteLine(pp.ping("ping"));
}
Pong pp = new Pong();
for (int i = 0; i < 3; ++i)
{
    UseIt(pp);
}

[Route("api/[controller]")]
public class PingPongController : Controller
{
    [HttpGet("{msg}")]
    public string Get(string msg)
    {
        return msg + "pong";
    }
}

class RemotePong : IPingable
{
    string Ping(string message)
    {
        string uri = "http://localhost:9149/api/pingpong/" + message;
        return new WebClient().DownloadString(uri);
    }
}

RemotePong pp; // was Pong
for (int i = 0; i < 3; ++i)
{
    UseIt(pp);
}

//Dynamiczny pełnomocnik do logowania
public interface IBankAccount
{
    void Deposit(int amount);
    bool Withdraw(int amount);
}

var ba = new BankAccount();
ba.Deposit(100);
ba.Withdraw(50);
WriteLine(ba);

public class Log<T> : DynamicObject
where T : class, new()
{
    private readonly T subject;
    private Dictionary<string, int> methodCallCount =
    new Dictionary<string, int>();
    protected Log(T subject)
    {
        this.subject = subject;
    }
}

public override bool TryInvokeMember(
InvokeMemberBinder binder, object[] args, out object result)
{
    try
    {
        if (methodCallCount.ContainsKey(binder.Name))
            methodCallCount[binder.Name]++;
        else
            methodCallCount.Add(binder.Name, 1);
        result = subject
        ?.GetType()
        ?.GetMethod(binder.Name)
        ?.Invoke(subject, args);
        return true;
    }
    catch
    {
        result = null;
        return false;
    }
}

public static I As<I>() where I : class
{
    if (!typeof(I).IsInterface)
        throw new ArgumentException("Argument musi być interfejsem");
    // tutaj duck typing!
    return new Log<T>(new T()).ActLike<I>();
}

//var ba = new BankAccount();
var ba = Log<BankAccount>.As<IBankAccount>();

ba.Deposit(100);
ba.Withdraw(50);
WriteLine(ba);

// Metoda Deposit wywołana 1 raz
// Metoda Withdraw wywołana 1 raz

