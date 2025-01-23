namespace ShopDecorator
{
    internal class Shop
    {
        public virtual void PayByCard()
        {
            Console.WriteLine("Zapłacone kartą");
        }

        public void PayByCach()
        {
            Console.WriteLine("Zapłacone gotówką");
        }

        public void PayByCheck()
        {
            Console.WriteLine("Zapłacone czekiem");
        }

    }
}
