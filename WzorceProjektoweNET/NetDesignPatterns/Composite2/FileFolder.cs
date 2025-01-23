namespace Composite2
{
    // Komponent
    public interface IFileSystemItem
    {
        void Display(int depth);
    }

    // Liść
    public class File : IFileSystemItem
    {
        private string _name;

        public File(string name)
        {
            _name = name;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name);
        }
    }

    // Kompozyt
    public class Directory : IFileSystemItem
    {
        private string _name;
        private List<IFileSystemItem> _items = new List<IFileSystemItem>();

        public Directory(string name)
        {
            _name = name;
        }

        public void Add(IFileSystemItem item)
        {
            _items.Add(item);
        }

        public void Remove(IFileSystemItem item)
        {
            _items.Remove(item);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name);
            foreach (var item in _items)
            {
                item.Display(depth + 2);
            }
        }
    }
}
