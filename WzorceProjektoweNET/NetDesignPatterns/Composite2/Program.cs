Composite2.Directory root = new("root");
root.Add(new Composite2.File("file1.txt"));
root.Add(new Composite2.File("file2.txt"));

Composite2.Directory subDirectory = new("subdir");
subDirectory.Add(new Composite2.File("file3.txt"));
root.Add(subDirectory);

root.Display(1);