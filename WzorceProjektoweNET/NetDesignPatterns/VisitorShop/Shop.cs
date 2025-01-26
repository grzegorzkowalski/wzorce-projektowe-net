namespace VisitorShop
{
    // Interfejs odwiedzającego
    public interface IProductVisitor
    {
        void Visit(Book book);
        void Visit(Electronics electronics);
    }

    // Interfejs produktu
    public interface IProduct
    {
        void Accept(IProductVisitor visitor);
        decimal GetBasePrice();
    }

    // Konkretny produkt: Książka
    public class Book : IProduct
    {
        public string Title { get; private set; }
        public decimal BasePrice { get; private set; }

        public Book(string title, decimal basePrice)
        {
            Title = title;
            BasePrice = basePrice;
        }

        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }

        public decimal GetBasePrice()
        {
            return BasePrice;
        }
    }

    // Konkretny produkt: Elektronika
    public class Electronics : IProduct
    {
        public string Model { get; private set; }
        public decimal BasePrice { get; private set; }

        public Electronics(string model, decimal basePrice)
        {
            Model = model;
            BasePrice = basePrice;
        }

        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }

        public decimal GetBasePrice()
        {
            return BasePrice;
        }
    }

    // Konkretny odwiedzający: Obliczanie ceny po zniżce
    public class DiscountCalculator : IProductVisitor
    {
        public void Visit(Book book)
        {
            decimal discountPrice = book.GetBasePrice() * 0.9m; // 10% zniżki
            Console.WriteLine($"Cena książki \"{book.Title}\" po zniżce wynosi: {discountPrice} zł");
        }

        public void Visit(Electronics electronics)
        {
            decimal discountPrice = electronics.GetBasePrice() * 0.95m; // 5% zniżki
            Console.WriteLine($"Cena elektroniki \"{electronics.Model}\" po zniżce wynosi: {discountPrice} zł");
        }
    }

    // Konkretny odwiedzający: Obliczanie kosztów dostawy
    public class ShippingCalculator : IProductVisitor
    {
        public void Visit(Book book)
        {
            Console.WriteLine($"Koszt dostawy książki \"{book.Title}\" wynosi: 5 zł");
        }

        public void Visit(Electronics electronics)
        {
            Console.WriteLine($"Koszt dostawy elektroniki \"{electronics.Model}\" wynosi: 15 zł");
        }
    }
}
