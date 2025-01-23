Notepad notepad = new Notepad();
NotepadHistory history = new NotepadHistory();

// Dodawanie tekstu i zapisywanie stanu
notepad.AddText("Pierwsza linia tekstu.");
history.SaveState(notepad.Save());

notepad.AddText("Druga linia tekstu.");
history.SaveState(notepad.Save());

notepad.AddText("Trzecia linia tekstu.");
history.SaveState(notepad.Save());

notepad.Display();

// Cofnięcie ostatniej operacji
notepad.Restore(history.Undo());
notepad.Display();

// Cofnięcie jeszcze jednej operacji
notepad.Restore(history.Undo());
notepad.Display();