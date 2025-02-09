namespace MementoNotepad
{
    public class NoteMemento
    {
        public string Content { get; }

        public NoteMemento(string content)
        {
            Content = content;
        }
    }

    // Klasa Notatka (Originator)
    public class Notepad
    {
        private string _content = "";

        // Dodawanie linii tekstu do notatki
        public void AddText(string text)
        {
            _content += text + "\n";
            Console.WriteLine($"Dodano: \"{text}\"");
        }

        // Wyświetlanie notatki
        public void Display()
        {
            Console.WriteLine("Aktualna notatka:");
            Console.WriteLine(_content);
        }

        // Tworzy Memento do zapamiętania bieżącego stanu
        public NoteMemento Save()
        {
            return new NoteMemento(_content);
        }

        // Przywraca stan z Memento
        public void Restore(NoteMemento memento)
        {
            _content = memento.Content;
            Console.WriteLine("Przywrócono poprzedni stan notatki.");
        }
    }

    // Klasa Caretaker zarządzająca historią stanów notatki
    public class NotepadHistory
    {
        private Stack<NoteMemento> _history = new Stack<NoteMemento>();

        public void SaveState(NoteMemento memento)
        {
            _history.Push(memento);
        }

        public NoteMemento Undo()
        {
            return _history.Count > 0 ? _history.Pop() : null;
        }
    }
}
