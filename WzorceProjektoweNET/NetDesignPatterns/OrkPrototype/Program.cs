using OrkPrototype;

Ork originalOrk = new Ork
{
    Age = 25,
    Strength = 150,
    Speed = 100
};

// Tworzenie kopii za pomocą wzorca Prototype
Ork clonedOrk = originalOrk.DeepCopy();

// Wyświetlanie informacji o oryginalnym i sklonowanym orku
Console.WriteLine($"Original Ork: Age={originalOrk.Age}, Strength={originalOrk.Strength}, Speed={originalOrk.Speed}");
Console.WriteLine($"Cloned Ork: Age={clonedOrk.Age}, Strength={clonedOrk.Strength}, Speed={clonedOrk.Speed}");
