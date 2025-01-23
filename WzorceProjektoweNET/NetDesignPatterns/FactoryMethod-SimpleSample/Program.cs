using FactoryMethod_SimpleSample;

Console.WriteLine("Wybierz typ dokumentu do stworzenia (pdf/word):");
string documentType = Console.ReadLine();

DocumentFactory factory = documentType.ToLower() switch
{
    "pdf" => new PdfDocumentFactory(),
    "word" => new WordDocumentFactory(),
    _ => throw new ArgumentException("Nieznany typ dokumentu"),
};

Document document = factory.CreateDocument();
document.Print();