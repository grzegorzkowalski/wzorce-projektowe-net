using TemplateMethodDocument;

DocumentProcessor pdfProcessor = new PDFProcessor();
DocumentProcessor wordProcessor = new WordProcessor();

Console.WriteLine("Przetwarzanie dokumentu PDF:");
pdfProcessor.ProcessDocument(); // Wykonuje kroki specyficzne dla PDF

Console.WriteLine("\nPrzetwarzanie dokumentu Word:");
wordProcessor.ProcessDocument(); // Wykonuje kroki specyficzne dla Word