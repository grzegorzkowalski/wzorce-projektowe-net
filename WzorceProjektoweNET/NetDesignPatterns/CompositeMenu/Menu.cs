namespace CompositeMenu
{
    // Komponent
    public interface IMenuItem
    {
        void Display(int depth);
    }

    // Liść
    public class Dish : IMenuItem
    {
        private string _name;

        public Dish(string name)
        {
            _name = name;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name);
        }
    }

    // Kompozyt
    public class MenuCategory : IMenuItem
    {
        private string _name;
        private List<IMenuItem> _items = new List<IMenuItem>();

        public MenuCategory(string name)
        {
            _name = name;
        }

        public void Add(IMenuItem item)
        {
            _items.Add(item);
        }

        public void Remove(IMenuItem item)
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
