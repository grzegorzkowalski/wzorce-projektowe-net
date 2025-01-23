namespace FactoryMethod_SimpleSample
{
    // Abstrakcyjny produkt
    public abstract class Document
    {
        public abstract void Print();
    }

    // Konkretne produkty
    public class PdfDocument : Document
    {
        public override void Print()
        {
            Console.WriteLine("Drukuję dokument PDF!");
        }
    }

    public class WordDocument : Document
    {
        public override void Print()
        {
            Console.WriteLine("Drukuję dokument Word!");
        }
    }
}
