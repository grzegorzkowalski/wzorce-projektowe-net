namespace FactoryMethod_SimpleSample
{
    // Abstrakcyjna fabryka
    public abstract class DocumentFactory
    {
        public abstract Document CreateDocument();
    }

    // Konkretne fabryki
    public class PdfDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new PdfDocument();
        }
    }

    public class WordDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new WordDocument();
        }
    }
}
