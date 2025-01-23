//Here's a new supplier for our restaurant
using Memento_sample;

FoodSupplier s = new FoodSupplier();
s.Name = "Harold Karstark";
s.Phone = "(482) 449-1172";

// Let's store that entry in our database.
SupplierMemory m = new SupplierMemory();
m.Memento = s.SaveMemento();

// Continue changing originator
s.Address = "548 S Main St. Nowhere, KS";

// Crap, gotta undo that entry, I entered the wrong address
s.RestoreMemento(m.Memento);

Console.ReadKey();
