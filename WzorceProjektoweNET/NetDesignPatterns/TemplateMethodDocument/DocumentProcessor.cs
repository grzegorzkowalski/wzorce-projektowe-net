using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDocument
{
    public abstract class DocumentProcessor
    {
        // Metoda szablonowa definiująca szkielet przetwarzania dokumentu
        public void ProcessDocument()
        {
            OpenDocument();
            ParseContent();
            DisplayContent();
            CloseDocument();
        }

        // Wspólne kroki dla wszystkich typów dokumentów
        private void OpenDocument()
        {
            Console.WriteLine("Otwieranie dokumentu");
        }

        private void CloseDocument()
        {
            Console.WriteLine("Zamykanie dokumentu");
        }

        // Abstrakcyjne metody, które muszą zostać zaimplementowane przez podklasy
        protected abstract void ParseContent();
        protected abstract void DisplayContent();
    }

    // Klasa pochodna: Procesor PDF
    public class PDFProcessor : DocumentProcessor
    {
        protected override void ParseContent()
        {
            Console.WriteLine("Parsowanie treści dokumentu PDF");
        }

        protected override void DisplayContent()
        {
            Console.WriteLine("Wyświetlanie treści dokumentu PDF");
        }
    }

    // Klasa pochodna: Procesor Word
    public class WordProcessor : DocumentProcessor
    {
        protected override void ParseContent()
        {
            Console.WriteLine("Parsowanie treści dokumentu Word");
        }

        protected override void DisplayContent()
        {
            Console.WriteLine("Wyświetlanie treści dokumentu Word");
        }
    }
}
