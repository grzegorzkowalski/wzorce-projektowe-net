using SantaClausFactoryLive;

var elf = new Elf();

// Dodanie komend
elf.SetCommand(1, "Samochodzik");
elf.SetCommand(2, "Rózga");
elf.SetCommand(1, "Klocki Lego");

// Wykonanie wszystkich komend
elf.ExecuteAll();

// Wyświetlenie prezentów
foreach (var gift in elf.GetPreparedGifts())
{
    Console.WriteLine($"Przygotowano: {gift.Name} ({gift.Type})");
}

// Cofnięcie ostatniej komendy
elf.UndoLastCommand();