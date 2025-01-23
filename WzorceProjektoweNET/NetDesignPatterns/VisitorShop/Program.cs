IProduct book = new Book("C# Programming", 50m);
IProduct electronics = new Electronics("Smartphone XYZ", 500m);

IProductVisitor discountCalculator = new DiscountCalculator();
IProductVisitor shippingCalculator = new ShippingCalculator();

// Obliczanie ceny po zniżce
book.Accept(discountCalculator); // Cena książki po zniżce wynosi: 45 zł
electronics.Accept(discountCalculator); // Cena elektroniki po zniżce wynosi: 475 zł

// Obliczanie kosztów dostawy
book.Accept(shippingCalculator); // Koszt dostawy książki wynosi: 5 zł
electronics.Accept(shippingCalculator); // Koszt dostawy elektroniki wynosi: 15 zł