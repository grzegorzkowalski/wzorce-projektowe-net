## W Folderze Samples s¹ dostêpne przyk³ady dla wszystkich klasycznychwzorcó projektowych Gangu Czworga.

## W folderze Tasks s¹ dostêpne przyk³adowe rozwi¹zania poni¿szych zadañ z wzorców.

## Singleton

### Zadanie 1
1. Stwórz now¹ aplikacjê konsolow¹ `SingletonVault`
1. Stwórz klasê o nazwie `Vault`. Zadaniem tej klasy jest zwrócenie cyfrowego klucza dostêpowego do skarbca.
1. Dlatego upewnij siê, ¿e jesteœ w stanie zwróciæ klucz tylko raz.

## Factory

### Zadanie 1
1. Stwórzy klasê Wojownik. Utwórz klasy dziedzicz¹ce Piechur, Strzelec, Konny.
1. Stwórz klasê garnizon, która na podstawie nazwy profesji wyszkoli i zwróci nam obiekt odpowiedniego wojownika.
1. Stwórz tablicê zawieraj¹c¹ 3 piechurów, 3 konnych i 4 strzelców.

## Builder

### Zadanie 1
1. Utwórz klasê abstrakcyjn¹ WarriorBuilder.
1. Utwórz klasy PiechurBuilder, StrzelecBuilder, KonnyBuilder.
1. Stwórz klasê Garnizon, której zadaniem bêdzie szkolenie wojowników o odpowiedniej profesji.
1. Szkolenie powinno przebiegaæ w 3 krokach. Zapisanie siê do armii (utworzenie obiektu odpowiedniego typu), pobranie broni, trening walki.
1. Wykorzystaj klasy wojowników z poprzedniego zadania. 
1. Stwórz nowy garnizon i dodaj tam 2 piechurów, 2 konnych i 2 strzelców. 
1. Mo¿esz wykorzystaæ interface `IWarrior` i listê generyczn¹ `List<IWarrior>`;

## Prototype

### Zadanie 1
1. Stwórz klasê Ork.
1. Stwórz nowego orka.
1. Za pomoc¹ serializacji i deserializacji w pêtli stwórz kilka klonów utworzonego nowego obiektu klasy ork i dodaj do kolekcji.
1. Zmieniaj im losowo np. parametr si³a. 
1. Wykorzystaj https://www.newtonsoft.com/json/help/html/SerializingJSON.htm

## Facade

### Zadanie 1
1. Wykorzystaj serwis pogodowy https://openweathermap.org/, który umo¿liwia pobieranie informacji o pogodzie.
1. Zaprojektuj fasadê dla tej us³ugi. Fasada powinna udostêpniaæ uproszczony interfejs do korzystania z us³ugi, np. metodê, która zwraca aktualn¹ temperaturê w danym mieœcie.
1. Stwórz interfejs u¿ytkownika w konsoli, który pozwoli u¿ytkownikowi na wybór miasta i wyœwietli aktualn¹ temperaturê w tym mieœcie.
1. Zaimplementuj fasadê, aby korzystaæ z zewnêtrznego API, aby pobraæ informacje o pogodzie i zwróciæ uproszczony interfejs do wykorzystania w interfejsie u¿ytkownika.
1. Przetestuj aplikacjê, upewniaj¹c siê, ¿e fasada dzia³a poprawnie i udostêpnia uproszczony interfejs u¿ytkownika do korzystania z zewnêtrznego API.
1. Wykorzystaj do komunikacji klasê: HttpClient  
https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient

Przyk³ad u¿ycia: 
https://gist.github.com/AliA1997/b4b3e1066dd9f31a78554438ab5d61bd

## Proxy

### Zadanie 1
1. Stwórz dwie klasy. Jedna ma reprezentowaæ obiekt dostêpny bez ograniczeñ, druga obiekt zastrze¿ony (dostêp ograniczony has³em).
1. Zaprojektuj proxy, który bêdzie kontrolowaæ dostêp do plików po przez sprawdzenie czy has³o zwrócone zosta³o poprawnie.
1. Stwórz interfejs u¿ytkownika w konsoli, który pozwoli u¿ytkownikowi na wybór obiektu do pobrania i wprowadzenie has³a.
1. Przetestuj aplikacjê, upewniaj¹c siê, ¿e proxy dzia³a poprawnie i kontroluje dostêp do obiektów.

## Adapter

### Zadanie 1
1. Naszym zadaniem jest przechytrzyæ bramkarza w klubie nocnym.
1. Nasz 17 letni Krzyœ chce dostaæ siê do klubu i potañczyæ, ale nie przechodzi walidacji (np. metoda IsAdult).
1. Napisz adapter klasê `FakeAdult`, która dziedziczy po klasie `Adult`.
1. Zadaniem adaptera jest oszukaæ walidacjê i pozwoliæ naszemu bohaterowi wejœæ i pobawiæ siê w klubie.


## Bridge

### Zadanie 1
1. WyobraŸmy sobie pulpit w naszym systemie operacyjnym. Dla systemu Windows jest to zazwyczaj oczywiste, ¿e bêdziemy korzystaæ z interface'u graficznego. Natomiast u¿ytkownik Linux mo¿e sobie interface wybraæ.
2. Dlatego nie chcemy na sta³e wi¹zaæ interface z systemem operacyjnym.
3. Proszê wdro¿yæ odpowiednie klasy (np. System, LinuxSystem, Interface, GraphicInterface).
4. Proszê wdro¿yæ relacje miêdzy tymi elementami za pomoc¹ wzorca bridge.
5. Przetestuj poprawnoœæ rozwi¹zanie. Niech naciœniecie przycisku menu w naszym interface zwróci nam z systemu listê zainstalowanych programów. (na potrzeby zadania bêdzie to wywo³anie w konsoli funkcji `displayMenu`).

## Decorator

### Zadanie 1
1. Przygotuj klasê sklepu np. `Shop`.
2. Dodaj mo¿liwoœæ p³acenia 3 ró¿nymi sposobami p³atnoœci (nie implementuj prawdziwego po³¹czenia z systemem p³atnoœci).
3. Je¿eli u¿ytkownik zap³aci kart¹ powinien uruchamiaæ siê dekorator. 
4. Dodaj 3 dekoratory, które bêd¹ wykonywa³y siê przy p³atnoœci. Np. powiadomienie sms o p³atnoœci, dodanie punktów lojalnoœciowych, przekierowanie na stronê g³ówn¹ sklepu.

## Command

### Zadanie 1

1. Stwórz klasê `SantaClausFactory`. Jej zadaniem bêdzie odbieranie odpowiednich poleceñ (commands) i produkowanie zabawek lub rózg.
2. Stwórz klasê pomocnika Œwiêtego Miko³aja, który bêdzie przekazywa³ polecenia do fabryki.  
3. Wykonaj 3 zabawki i jedn¹ rózgê.


## Observer

### Zadanie 1

1. Za³ó¿my, ¿e jest grupa studentów, która oczekuje na wyniki egzaminu i jest obiekt wyk³adowca.
2. Napisz implementacje wzorca obserwatora w ten sposób, ¿e w momencie, gdy wyk³adowca og³osi wyniki, ka¿dy student dostanie informacje o swoim wyniku.

## Strategy

## Zadanie 1

1. W naszej redakcji internetowej chcielibyœmy móc w ³atwy sposób przeszukaæ ró¿ne bazy zdjêæ.
2. Zaimplementuj rozwi¹zanie, które w zale¿noœci od preferencji pozwoli przeszukaæ bazê zdjêæ [Pexels](https://www.pexels.com/api/) 
lub bazê zdjêæ [Pixabay](https://pixabay.com/api/docs/), po wybranej nazwie kategorii.
3. Wykonaj wszystkie wymagane kroki, ¿eby móc korzystaæ z API dla obu rozwi¹zañ.