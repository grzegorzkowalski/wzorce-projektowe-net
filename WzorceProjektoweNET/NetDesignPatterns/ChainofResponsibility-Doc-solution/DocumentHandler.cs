using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility_Doc_solution
{
    public abstract class DocumentHandler
    {
        protected DocumentHandler _nextHandler;

        public void SetNextHandler(DocumentHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleDocument(string priority);
    }
    // Klasa konkretnego handlera: Pracownik pierwszego poziomu
    public class LowPriorityHandler : DocumentHandler
    {
        public override void HandleDocument(string priority)
        {
            if (priority == "Niski")
            {
                Console.WriteLine("Pracownik pierwszego poziomu przetwarza dokument o niskim priorytecie.");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine("Pracownik pierwszego poziomu przekazuje dokument dalej.");
                _nextHandler.HandleDocument(priority);
            }
        }
    }

    // Klasa konkretnego handlera: Pracownik drugiego poziomu
    public class MediumPriorityHandler : DocumentHandler
    {
        public override void HandleDocument(string priority)
        {
            if (priority == "Średni")
            {
                Console.WriteLine("Pracownik drugiego poziomu przetwarza dokument o średnim priorytecie.");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine("Pracownik drugiego poziomu przekazuje dokument dalej.");
                _nextHandler.HandleDocument(priority);
            }
        }
    }

    // Klasa konkretnego handlera: Pracownik trzeciego poziomu
    public class HighPriorityHandler : DocumentHandler
    {
        public override void HandleDocument(string priority)
        {
            if (priority == "Wysoki")
            {
                Console.WriteLine("Pracownik trzeciego poziomu przetwarza dokument o wysokim priorytecie.");
            }
            else
            {
                Console.WriteLine("Dokument o priorytecie " + priority + " nie może być przetworzony.");
            }
        }
    }
}
