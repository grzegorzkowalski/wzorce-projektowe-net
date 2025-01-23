namespace ShopDecorator
{
    internal class Decorator : Shop
    {
        public void SMSNotification()
        {
            Console.WriteLine("Pobrano płatnośc z banku");
        }
        public void LoyaltyPointsAdd()
        {
            Console.WriteLine("Dodano punkty lojalnościowe");
        }
        public void Redirect()
        {
            Console.WriteLine("Wracamy na stornę główną");
        }

        public override void PayByCard()
        {
            base.PayByCard();
            SMSNotification();
            LoyaltyPointsAdd();
            Redirect();
        }

    }
}
