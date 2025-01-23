## Warsztat

#### Zadanie 1

1. Utwórz nową solucję o nazwie Library.
2. W solucji utwórz projekt Library.ConsoleApp typu aplikacja konsolowa.
3. W solucji utwórz projekt Library.Domain typu ClassLib.
4. W solucji utwórz projekt Library.Persistence typu ClassLib.
5. W projekcie Library.Persistence dodaj referencję do projektu Library.Domain.
6. W projekcie Library.ConsoleApp dodaj referencję do projektów Library.Domain i Library.Persistence.
7. W projekcie Library.Domain utwórz klasę książki, mozesz ją skopiować z kodu poniżej.
```csharp
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }

        public int ProductsAvailable { get; set; }
        public decimal Price { get; set; }
        
        public Book() {}

        public Book(string title, string author, int publicationYear, string isbn, int productsAvailable, decimal price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            ProductsAvailable = productsAvailable;
            Price = price;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} ProductsAvailable: {ProductsAvailable}";
        }
    }
}
```
8. W projekcie Library.Persistence utwórz klasę BooksRepository, na chwilę obecną moze to byc pusta klasa.
9. W projekcie Library.ConsoleApp w pliku Program.cs utworz obiekt wczesniej utworzonych klas.
```csharp
Book book = new Book(/*uzupełnij parametry*/);
BooksRepository repository = new BooksRepository();
```
10. Skompiluj projek aby sprawdzic czy nie ma w nim błędów.
11. Utwórz katalog solucji Presentation.
12. Przenies do katalogu Presentation projekt Library.ConsoleApp.
13. Utworz katalog solucji Logic.
14. Przenies do katalogu Logic projekty Library.Domain oraz Library.Persistence.

#### Zadanie 2

1. Otwórz plik Program.cs w projekcie Library.ConsoleApp.
2. Za pomocą API obiektu console, pobierz od uzytkownika jego login i hasło
```csharp
string text = Console.ReadLine();
```
3. Jezeli login to `Admin` a hasło to `password` wypisz na consoli napis `Access Granted`.
4. W przeciwnym wypadku wypisz napis `Access Denied`.
5. Za pomocą przycisku F9 (lub klikając w lewą kolumnę edytora) oznacz miejsce z if-em, tak aby wykonywanie programu zatrzymało się.
6. Urucham projekt Library.ConsoleApp w trybie Debug.
7. Za pomocą przycisku F10 przejdź przez flow programu.

#### Zadanie 3

1. Otworz plik Program.cs z aplikacji Library.ConsoleApp
2. Następnie za pomocą pętli zczytuj kolejne linie tekstu wprowadzone przez użytkownika.
3. Pętla ma zakończyć swoje zadanie kiedy użytkownik wpisze komendę `wyjdź`.
4. Pętla ma czekaż aż użytkownik wprowadzi komendę.
5. Wewnątrz pętli sprawdzaj jaką komendę podał użytkownik według poniższej rozpiski: 
   - dodaj -> Powinna wypisac tekst: "próba dodania książki"
   - usun -> Powinna wypisac tekst: "próba usuniecia książki"
   - wypisz -> Powinna wypisac tekst: "próba wypisania wszystkich książek"
   - zmien -> Powinna wypisac tekst: "próba zmiany stanu magazynowego książek"
   - dodaj zamowienie -> Powinna wypisac tekst: "próba dodania nowego zamówienia"
   - lista zamowien -> Powinna wypisac tekst: "próba wypisania wszystkich zamówień"
6. Wykorzystaj komende `Console.Clear()` aby po wprowadzeniu komendy ekran konsoli wypisywał tylko menu aplikacji.
7. Wykorzystaj komendę `Console.WriteLine` aby wyświetlić użytkownikowi możliwe do wpisania komendy.
8. *W przypadku kiedy uzytkownik poda nie wspierana komende, aplikacja powinna wyswietlic informacje ze podana komenda nie jest wspierana
9. *Po kazdej komendzie aplikacja powinna wyswietlic napis: `Press AnyKey` i wstrzymac wykonywanie programu do czasu wcisniecia klawisza

#### Zadanie 4

1. W projekcie Library.ConsoleApp stwórz klasę `BooksService`.
2. W klasie `BooksService` zaimplementuj takie metody jak: 
   - AddBook():void -> Powinno pobrać od użytkownika wszystkie dane potrzebne do stworzenia instancji klasy `Book`
   - RemoveBook():void -> Powinno pobrać od użytkownika tytuł książki do usunięcia
   - ListBooks():void -> Ta metoda powinna wyświetlić napis `Tutaj pojawi się lista książek`
   - ChangeState():void -> Ta metoda powinna pobrać od użytkowników tytuł książki, której stan ma się zmienić oraz samą zmianę stanu np. -1
Do konwersji string-a na int-a uzyj klasy Convert.
```csharp
Convert.ToInt32(Console.ReadLine());
```
3. Przejdź do pliku `Program.cs` w projekcie Library.ConsoleApp.
4. Przed pętlą utwórz obiekt klasy `BooksService`.
5. W środku pętli podmień wyświetlanie tekstów na wywołanie odpowiedniej metody z obiektu klasy `BooksService`
6. Uruchom aplikację i sprawdź czy wszystko działa poprawnie.

#### Zadanie 5

1. Otwórz klasę `BooksRepository` znajdującą się w projekcie Library.Persistence.
2. Utwórz pole `readonly List<Book>` o nazwie _database.
3. Utwórz bezparametrowy konstruktor.
4. W konstruktorze dodaj kilka książek, możesz do tego użyć poniższych: 
```csharp
    new Book("Stary człowiek i morze", "Ernest Hemingway", 1986, "AAAA", 10, 19.99m),
    new Book("Komu bije dzwon", "Ernest Hemingway", 1997, "BBBB", 0, 119.99m),
    new Book("Alicja w krainie czarów", "C.K. Lewis", 1998, "CCCC", 53, 39.99m),
    new Book("Opowieści z Narnii", "C.K. Lewis", 1999, "DDDD", 33, 49.99m),
    new Book("Harry Potter", "J.K. Rowling", 2000, "EEEE", 23, 69.99m),
    new Book("Paragraf 22", "Joseph Heller", 2001, "FFFF", 5, 45.99m),
    new Book("Lalka", "Bolesław Prus", 2002, "GGGG", 7, 76.99m),
    new Book("To", "Stephen King", 2003, "HHHH", 2, 12.99m),
    new Book("Idiota", "Fiodor Dostojewski", 1950, "IIII", 89, 25.99m),
    new Book("Mistrz i Małgorzata", "Michaił Bułhakow", 1965, "JJJJ", 41, 36.99m),   
```
5. Dodaj metodę `Insert(Book book): void`, która będzie odpowiedzialna za dodawanie nowej książki do listy.
6. Dodaj metodę `GetAll(): List<Book>`, która będzie zwracac wszystkie książki, które znajdują się w repozytorium.
7. Dodaj metodę `RemoveByTitle(string title): void`, która będzie kasować wybraną książkę z repozytorium. Aby szybciej namierzyć książkę możesz uzyć poniższego wyrażenia LINQ.
```csharp
.First(x => x.Title == title)
```
8. Dodaj metode `ChangeState(string title, in stateChange)`, która będzie uaktualniać stan w wybranym tytule. Wykorzystaj wyrażenie LINQ z poprzedniego ćwiczenia.
9. Przejdź do pliku `BooksService` w projekcie Library.ConsoleApp.
10. Utwórz konstruktor, w którym jedynym parametrem będzie obiekt klasy `BooksRepository`.
11. Przypisz obiekt klasy `BooksRepository` do pola w klasie o nazwie `_repository`.
12. Wykorzystaj obiekt `_repository` w wywołaniach metod klasy `BooksService`.
13. Przejdź do pliku `Program.cs` i przed utworzeniem obiektu `BooksService` utwórz obiekt klasy `BooksRepository`.
14. Przekaż obiekt klasy `BooksRepository` do konstruktora klasy `BooksService`.
15. Przetestuj czy można dodać nową książkę do repozytorium. 

#### Zadanie 6

1. Otwórz projekt Library.Domain.
2. Stwórz klasę BookOrdered, która powinna zawierać: 
    - propertis BookId typu int
    - propertis NumerOrdered typu int.
3. Stwórz klasę Order, która powinna zawierać: 
    - propertis Date typu DateTime
    - propertis BooksOrderedList typu `List<BookOrdered>`
    - Bezparametrowy konstruktor, w którego ciele zastaną wykonane następujące akcję:
        - ustawienie propertisa Date na wartość `DateTime.Now`
        - zainicjalizowanie listy BooksOrderedList pustą listą.
    - Metodę ToString (pamiętaj o użyciu `override`), która wygeneruje ciąg znaków w postaci:
        ```
        Order: DataUtworzenia obiektu
        Book: IdKsiazki Count: IloscZamowionych ksiazek
        ```
        w tym celu mozesz uzyc interpolacji stringów
        ```csharp
            string str = "Test";
            str += $"Test: {JakasZmienna} Test2: {JakasZmienna}";
        ```
4. Przejdź do projektu Library.Persistence.
5. Utwórz klasę `OrdersRepository`.
6. Wewnątrz klasy `OrdersRepository` utwórz prywatne pole `database` typu List<Order>, które od razu zainicjalizu pustą listą.
7. Wewnątrz klasy `OrdersRepository` zaimplementuj dwie metody: 
    - `Insert(Order order): void` -> wywołanie tej metody ma dodawać elementy do kolekcji
    - `GetAll(): List<Order>` -> wywołanie tej metody ma zwrócic wszystkie wczesniej dodane order-y.
8. Przejdź do projektu Library.ConsoleApp.
9. Utwórz klasę `OrderService`.
10. W klasie `OrderService` utwórz konstruktor, który będzie przyjmował obiekt klasy `OrdersRepository` jako swój parametr.
11. W konstruktorze klasy `OrderService` przypisz obiekt klasy `OrderRepository` do prywatnego pola o nazwie `_orderRepository`.
12. W klasie `OrderService` zaimplementuj metodę `PlaceOrder`, która będzie odpowiedzialna za proces składania nowego zamówienia:
    - utworzenie obiektu klasy `Order`,
    - wypisanie menu w postaci: 
    ```
        add - dodaj pozycje do zamowienia
        end - zamknij zamowienie
    ```
    - W momencie wpisania komendy `add`, program powinien zapytac uzytkownika o: 
        - id książki
        - ilość 
    - Następnie utworzyc obiekt klasy `BookOrdered` i dodać go do pola `BooksOrderedList` z obiektu `order`.
    - Następnie powrócić do menu `add / end` aby było możliwe dodanie więcej niż tylko jednej pozycji w zamówieniu.
    - W momencie wpisania komendy `end` program powinien dodac obiekt `order` do repozytorium.
13. W klasie `OrderService` zaimplementuj metodę `ListAll`, której zadaniem będzie wypisanie wszystkich zamowień pobranych z repozytorium.
14. Przejdź do pliku `Program.cs` w projekcie Library.ConsoleApp.
15. Utwórz obiekt klasy `OrdersRepository` przed główną pętlą programu.
16. Utwórz obiekt klasy `OrdersService`, wykorzystując przy tym wczesniej utworzony obiekt klasy `OrdersRepository`.
17. Wykorzystaj obiekt klasy `OrdersService` aby podpiąć jego metody do zadan:
    - dodaj zamówienie
    - lista zamówien.
18. Uruchom aplikację Library.ConsoleApp w trybie debug-u.
19. Przetestuj czy dodawanie zamowien działa poprawnie.
20. *Zrób zabezpieczenie aby nie dało się dodać do zamówienia książki, której nie ma w repozytorium.
21. *Zrób zabezpieczenie aby do zamówienia nie dało się dodać więcej książek, niż jest w repozytorium.

#### Zadanie 7

1. Otwórz plik Book.cs znajdujący się w projekcie Library.Domain.
2. Ze wszystkich property skasuj operator set. 
3. Dla property `ProductsAvailable` dodaj operator set wraz z modyfikatorem prywatności private.
4. Dodaj do klasy Book nową metodę, która będzie odpowiedzialna za modyfikację stanu magazynowego. Tą metodę nazwij: `ChangeProductsAvailableNumber(int change)`.
5. Przejdź do pliku BooksRepository w projekcie Library.Persistence i w metodzie ChangeState zmień ustawienie property na wywołanie metody z klasy Book.
6. Przejdź do pliku Order.cs w projekcie Library.Domain.
7. W propertach skasuj słowo kluczowe set.
8. Przejdź do pliku BookOrdered w projekcie Library.Domain.
9. Skasuj słowo kluczowe set w propertach.
10. Stwórz konstruktor, który musi zawierac dwa argumenty: Book(int bookId, int numberOrdered).
11. Otwórz plik OrderService znajdujacy sie w projekcie Library.ConsoleApp.
12. Zmien w lini gdzie jest dodawana nowa pozycja zamówienia inicjalizację klasy BookOrdered tak aby była zgodna z tym co przed chwilą było zrobione.     

#### Zadanie 8

1. Przejdz do projektu Library.Domain.
2. Utwórz interfejs IModel, ktora ma zawierać jeden propertis: int Id { get; set; }.
3. Utwórz klasę abstrakcyją BaseModel, która implementuje interfejs IModel.
4. Otwórz klasę Book.
5. Zastosuj dziedziczenie, aby klasa Book dziedziczyła po klasie BaseModel.
6. Otwórz klasę Order.
7. Zastosuj dziedziczenie, aby klasa Order dziedziczyła po klasie BaseModel.
8. Przejdź do projektu Library.Persistence.
9. Utworz klase BaseRepository, która będzie posiadać jeden parametr generyczny o nazwie T.
10. Oznacz, że parametr generyczny T musi implementowac interfejs IModel.
11. Stwórz pole Database typu `List<T>` wraz z zakresem widocznosci protected.
12. Stwórz pole Counter typu int wraz z zakresem widocznosci protected.
13. W klasie BaseRepository utwórz takie metody jak: 
    - Insert(T element): void -> Metoda powinna najpierw ustawic Id elementu na kolejną wartosc Counter-a. A dopiero następnie wstawic element do listy.
    - Remove(T element): void -> Metoda powinna usunać wybrany element z listy.
    - RemoveById(int id): void -> Metoda powinna usunać wybrany element z listy: 
    Możemy wykorzystac metode RemoveAll z API obiektu `List` i za pomoca wyrażenia lambda jasno określiź, że szukamy elementy o danym id: "x => x.Id == id".
    - GetAll(): `List<T>` -> Metoda zwraca wszystkie elementy, ktore znajdują się w liście.
    - virtual GetById(int id): T -> Metoda powinna zwracać tylko pojedynczy element odnaleziony po Id, mozemy tutaj zastosować innąa metodą pomocniczą z LINQ (SingleOrDefault).
14. Otworz plik BooksRepository.
15. Zmień kod tak, aby klasa BooksRepository dziedziczyła po klasie `BaseRepository<>`.
Book
16. Usuń niepotrzebne metody z klasy BooksRepository.
17. Otwórz plik OrdersRepository.
18. Zmień aby klasa OrdersRepository dziedziczyła po `BaseRepository<Order>`.
19. Usun zbędne elementy z klasy OrdersRepository.

#### Zadanie 9

1. Przejdź do projektu Library.ConsoleApp.
2. Utwórz interfejs IHandler, który ma zawierać jedną metodę Handle():void.
3. Utwórz interfejs ICommand, który ma zawierać dwie property: 
    - string Name { get; }
    - string Description { get; }.
4. Utwórz klasę Handler, która ma implementować interfejs IHandler.
5. Utwórz w klasie Handler konstruktor z jednym parametrem. Ten parametr ma być typu `Action` i nazywac sie `logic`.
6. Zapisz przekazany parametr do prywatnego pola w klasie o nazwie _logic.
7. Wewnątrz metody Handle uruchom wcześniej otrzymaną funkcję _logic (ex: "_logic()").
8. Utwórz klasę Command, która ma implementować interfejs ICommand.
9. Klasa Command ma posiadac konstruktor, ktory przyjmuje dwa parametry: 
    - string name
    - string description.
10. Utwórz klasę Procesor.
11. Klasa procesor ma zawierac prywatne pole typu Dictionary<ICommand, IHandler> o nazwie "_actions". Te pole powinno być od razu zaincjalizowane za pomoca "new Dictionary<ICommand, IHandler>()"
12. Klasa powinna miec prywatną statyczną metodę o nazwie "AfterCommand", w której powinien znaleźć się kod odpowiedzialny za wyświetlenie komunikatu: "Naciśnij dowolny przycisk aby kontynouwac." 
A następnie metoda ta powinna pobrać dowolny znak z klawiatury za pomoca "Console.ReadKey".
13. Zaimplementuj w klasie metode o nazwie "RegisterNewAction(ICommand, IHandler): void", która powinna dodać nowy command i nowy handler do słownika.
14. Zaimplementuj w klasie metodę o nazwie GetAllCommandsWithDescription(): string
Ciało funkcji możesz skopiować: 
    var sb = new StringBuilder();

    foreach (var (command, handler) in _actions)
    {
        sb.Append($"{command.Name} - {command.Description} \n");
    }

    return sb.ToString();
    
    +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
15. Zaimplementuj metodę HandlerCommand(string command): void.
16. Przejdź do pliku Program.cs.
17. Poniżej utworzenia serwisów i repozytorium, stwórz obiekt klasy Processor.
18. Podefiniuj akcje procesora wykorzystując metodę RegisterNewAction
_processor.RegisterNewAction(new Command(), new Handler(() => akcja))
(W przypadku komendy "wyjdz", prosze uruchomic kod Enviroment.Exit(0)).
19. Przenieś wypisywanie menu aplikacji do osobnej metody statycznej nazwij ja "DisplayMenu".
20. W metodzie DisplayMenu wykasuj kod odpowiedzialny za wyświetlanie nazw komend i ich opisów.
21. Wykorzystaj metodę obiektu processor-a aby wyswietlić menu aplikacji.
(Uwaga: będzie potrzeba zapisać sobie obiekt procesora jako pole klasy Program lub przekazać ten obiekt w parametrach wywołania tej funkcji).
22. Zamiast ogromnego if-a wywołaj funkcję _processor.HandleCommand(command) gdzie jako command przekaż ciąg znaków wprowadzony od użytkownika.
23. Na koniec możesz wynieść Autoryzację użytkownika do osobnej funkcji statycznej tak aby kod programu był nieco bardziej czysty.  

#### Zadanie 10

1. Przejdź` do projektu Library.Domain.
2. Otwórz kod źródłowy klasy Book.
3. Dla każdego parametru konstruktora napisz zabezpieczenie: 
   - Dla parametrów typu string użyj metody `string.IsNullOrWhiteSpace`.
   - Dla publicationYear napisz warunek, który sprawdzi czy data publikacji jest większa od 1000 i mniejsza niz obecny rok (`DateTime.UtcNow.Year`)
    - Dla productsAvailable wartosc ma być z przedziału <0;2000)
    - Dla Price ma być większe równe 0.00m.
    
    Pamiętaj aby dopasowac rodzaj rzuconego wyjątku do rodzaju wykroczenia: 
    - ArgumentOutOfRangeException
    - ArgumentNullException
4. Dodaj zabezpieczenie w metodzie ChangeProductsAvailableNumber. Pamiętając, że trzeba sprawdzić stan magazynowy po operacji arytmetycznej.
5. Przejdź do klasy BookOrdered.
6. Dodaj zabezpieczenia dla parametrów konstruktora aby nie mogły one przyjmować wartości
mniejszych od zera.
7. Przejdź do projektu Library.ConsoleApp.
8. W projekcie Library.ConsoleApp utwórz katalog `Exceptions`.
9. W katalogu Exceptions utwórz własny wyjątek `ActionNotSupportedException`, pamietaj o implementacji 3 konstruktorów.
    - ActionNotSupportedException() : base().
    - ActionNotSupportedException(string message) : base(message).
    - ActionNotSupportedException(string message, Exception inner) : base(message, inner).
    
#### Zadanie 11

1. Przejdź do projektu Library.ConsoleApp.
2. Utwórz katalog Attributes.
3. Utwórz klasę Command dziedziczącą po klasie System.Attribute.
4. Klasie Command dodaj atrybut `AttributeUsage(AttributeTargets.Class)`.
5. Utwórz konstruktor klasy Command, który posiada dwa parametry
    - name: string
    - description: string.
6. Stwórz dwa pola prywatne o typie string i nazwach: 
    - _name
    - _description.
7. Przypisz zmienne wprowadzone przez konstruktor do pól klasy zaimplementowanych w poprzednim punkcie
8. Stwórz metodę GetName która będzie zwracać pole _name.
9. Stwórz metodę GetDescription która będzie zwracać _description.

#### Zadanie 12

1. Przejdź do projektu Library.ConsoleApp.
2. Stwórz prywatne pole w klasie Processor, które będzie zawierało słownik <string, IHandler>o nazwie `actions`, od razu zainicjalizuj te pole.
3. Stwórz bezparametrowy konstruktor.
4. W konstruktorze za pomocą refleksji i zapytań LINQ pobierz wszystkie typy, które implementują interfejs `IHandler`.

            var type = typeof(IHandler);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p))
                .Where(p => !p.IsInterface)
                
5. Za pomocą wyrażenia LINQ `ToDictionary` utwórz słownik.
6. Jako klucz słownika zdefiniuj wyrażenie lambda, które pobierze Customowy atrybut (Comand)
z danego typu, a następnie pobierze pole name.
7. Jako drugie wyrażenie lambda wykorzystaj klase (IHandler)Activator.CreateInstance(Type) aby stworzyc instancje
8. Na koniec przypisz tak stworzony slownik do zmiennej _actions.
9. W metodzie HandleCommand wykorzystaj blok Try, Catch, Finally aby obsłuzyc błędy podczas wykonywania komend
10. Wywal wcześniej zdefiniowane wywołanie metody Handle na obiekcie.
11. Pobierz akcje do wykonania z listy akcji.
12. Dodaj zabezpieczenie: Jeżeli nie pobrało akcji z listy to powinno rzucić wyjątkiem ActionNotSupportedException.
13. Wywołaj metodę Handle na pobranej akcji.
14. W sekcji finally wywołaj metode AfterCommand.
15. Stwórz katalog Handlers.
16. Utworz klasy, niech kazda poniższa klasa implementuje interfejs IHandler
    - AddBookHandler
    - ChangeStateHandler
    - ExitHandler
    - ListBookHandler
    - ListOrderHandler
    - PlaceOrderHandler
    - RemoveBookHandler.
17. Przejdź do projektu Library.Persistence.
18. Stwórz klasyczną klasę Repositories.
19. W klasie repositories dodaj dwa statyczne pola.

    public static readonly BooksRepository BooksRepository = new BooksRepository();
    public static readonly OrderRepository OrderRepository = new OrderRepository();
    
20. W każdej klasie *Handler Przekopiuj odpowiednią logikę do metody Handle: 
    np. Dla klasy AddBookHandler trzeba przekopiować logikę z klasy BooksService z metody AddBook.
21. Dla handler-a `ExitHandler` ustaw implementacje metody Handle jako `Enviroment.Exit(0)`.
22. Po dodaniu logiki do każdego handler-a możesz skasować klasy BooksService i OrdersService
23. Możesz skasować ICommand i Command.
24. Przejdź do pliku Program.cs.
25. Skasuj odwołania do klas Command, BooksService i OrdersService.
26. Skasuj wszystkie wywołania metody RegisterNewAction na obiekcie procesor.
27. W pliku procesor mozesz skasowac metode RegisterNewAction.
28. W pliku Processor.cs w metodzie GetAllCommandsWithDescription do wyrazenie LINQ, które z wartości(_actions.Values) słownika pobierze typy.
29. Następnie za pomocą refleksji otrzyma informacje z Atrybutu Command (name, description).
30. Za pomocą metody `.Select((x) => $"{x.Key} - {x.Value}");` wygeneruje tablice podpisów w menu.
31. Za pomocą metody `string.join("\n", methods.ToArray());` zwróci menu aplikacji.