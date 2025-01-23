using SantaClausFactoryLive;

Elf elf = new Elf();
elf.AddWish(1, "Piłka");
elf.AddWish(2, "Rózga");
elf.Execute();

List<Gift> preparedGifts = elf.GetPreparedGifts(); // Pobranie przygotowanych prezentów
