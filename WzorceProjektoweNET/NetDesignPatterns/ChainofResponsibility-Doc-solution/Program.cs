// Tworzenie handlerów
using ChainofResponsibility_Doc_solution;

DocumentHandler lowPriorityHandler = new LowPriorityHandler();
DocumentHandler mediumPriorityHandler = new MediumPriorityHandler();
DocumentHandler highPriorityHandler = new HighPriorityHandler();

// Konfigurowanie łańcucha zobowiązań
lowPriorityHandler.SetNextHandler(mediumPriorityHandler);
mediumPriorityHandler.SetNextHandler(highPriorityHandler);

// Obsługa dokumentów
lowPriorityHandler.HandleDocument("Niski");   // Obsługuje pracownik pierwszego poziomu
lowPriorityHandler.HandleDocument("Średni");  // Przekazywane do pracownika drugiego poziomu
lowPriorityHandler.HandleDocument("Wysoki");  // Przekazywane do pracownika trzeciego poziomu
lowPriorityHandler.HandleDocument("Krytyczny"); // Nieobsłużone
