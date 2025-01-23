//Rozdział 5.
//Prototyp
// Kopiowanie głębokie i płytkie

public class Person
{
    public readonly string Name;
    public readonly Address Address;
    public Person(string name, Address address) { ... }
}

public class Address
{
    public readonly string StreetName;
    public int HouseNumber;
    public Address(string streetName, int houseNumber) { ... }
}

var jan = new Person(
    "Jan Kowalski",
    new Address("Mickiewicza", 123));
var janina = jan;
janina.Name = "Janina Kowalska";  //Imię Jana zmieniło się!
janina.Address.HouseNumber = 321; //Adres Jana zmienił się!

// ICloneable to zły pomysł

public class Person : ICloneable
{
    //składowe takie, jak poprzednio
    public Person Clone()
    {
        return (Person)MemberwiseClone();
    }
}
 var jan = new Person(
    "Jan Kowalski",
    new Address("Mickiewicza", 123));
var janina = jan.Clone();
janina.Name = "Janina Kowalska"; //Imię Jana NIE ZMIENIŁO SIĘ (dobrze!)
janina.Address.HouseNumber = 321; //Adres Jana się zmienił :-(

//Głębokie kopiowanie z wykorzystaniem specjalnego interfejsu

interface IDeepCopyable<T>
{
    T DeepCopy();
}

public class Person : IDeepCopyable<Person>
{
    public string[] Names;
    public Address Address;
    public Person DeepCopy()
    {
        var copy = new Person();
        copy.Names = Array.Copy(Names); // string[] nie implementuje interfejsu
                                           IDeepCopyable
        copy.Address = Address.DeepCopy(); // Address implementuje interfejs
                                          IDeepCopyable
        return copy;
    }
    //tutaj inne składowe
}

//Głębokie kopiowanie obiektów

var dt = new DateTime(2016, 1, 1);
var dt2 = dt; //kopia głęboka!
 string s = "witaj";
string w = s; // w odnosi się do ciągu "witaj"
w = "świecie"; // w odnosi się teraz do ciągu "świecie"
Console.WriteLine(s); // nadal wyświetla "witaj"
 var d = new Dictionary<string, int>
{
    ["foo"] = 1,
    ["bar"] = 2
};
var d2 = new Dictionary<string, int>(d);
d2["foo"] = 55;
Console.WriteLine(d["foo"]); //wyświetla 1
 var d = new Dictionary<string, Address>
{
    ["sherlock"] = new Address {HouseNumber = 221, StreetName =
    "Baker St"}
};
var d2 = new Dictionary<string, Address>(d);
d2["sherlock"].HouseNumber = 222;
Console.WriteLine(d["sherlock"].HouseNumber); // wyświetla "222"
 var d2 = d.ToDictionary(x => x.Key, x => x.Value.DeepCopy());

// Duplikacja za pomocą konstruktora kopiującego

public Address(Address other)
{
    StreetAddress = other.StreetAddress;
    City = other.City;
    Country = other.Country;
}
public Person(Person other)
{
    Name = other.Name;
    Address = new Address(other.Address); //tutaj używamy konstruktora kopiującego
}
 var jan = new Person(
    "Jan Kowalski",
    new Address("Mickiewicza", 123));
var janina = new Person(jan); //konstruktor kopiujący!
janina.Name = "Janina Kowalska";
janina.Address.HouseNumber = 321; // numer domu dla obiektu jan to nadal 123

//Serializacja

public static T DeepCopy<T>(this T self)
{
    using (var stream = new MemoryStream())
    {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, self);
        stream.Seek(0, SeekOrigin.Begin);
        object copy = formatter.Deserialize(stream);
        return (T) copy;
    }
}
 var foo = new Foo { Stuff = 42, Whatever = new Bar { Baz =
"abc"} };
var foo2 = foo.DeepCopy();
foo2.Whatever.Baz = "xyz"; //działa poprawnie

public static T DeepCopyXml<T>(this T self)
{
    using (var ms = new MemoryStream())
    {
        XmlSerializer s = new XmlSerializer(typeof(T));
        s.Serialize(ms, self);
        ms.Position = 0;
        return (T) s.Deserialize(ms);
    }
}

//Fabryka Prototypów
static Person main = new Person(null,
    new Address("Paderewskiego 123", "Warszawa", 0));
static Person aux = new Person(null,
    new Address("Paerewskiego 123B", "Warszawa", 0));

public class EmployeeFactory
{
    private static Person main =
        new Person(null, new Address("Paderewskiego 123", "Warszawa", 0));
    private static Person aux =
        new Person(null, new Address("Paerewskiego 123B", "Warszawa", 0));
    public static Person NewMainOfficeEmployee(string name, int
    suite) =>
        NewEmployee(main, name, suite);
    public static Person NewAuxOfficeEmployee(string name, int
    suite) =>
        NewEmployee(aux, name, suite);
    private static Person NewEmployee(Person proto, string name,
    int suite)
    {
        var copy = proto.DeepCopy();
        copy.Name = name;
        copy.Address.Suite = suite;
        return copy;
    }
}
var jan = EmployeeFactory.NewMainOfficeEmployee("Jan Domański", 100);
var janina = EmployeeFactory.NewAuxOfficeEmployee("Janina Domańska", 123);
 
