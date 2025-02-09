namespace ShopDecorator
{
    internal class DekoratorBezDziedziczenia
    {
        private Shop _shop;

        public DekoratorBezDziedziczenia(Shop shop)
        {
            _shop = shop;
        }

        public void SMSNotification()
        {
            Console.WriteLine("Pobrano płatnośc z banku.");
        }
        public void LoyaltyPointsAdd()
        {
            Console.WriteLine("Dodano punkty lojalnościowe.");
        }
        public void Redirect()
        {
            Console.WriteLine("Wracamy na stornę główną.");
        }

        public void PayByCard()
        {
            if (_shop != null)
            {
                _shop.PayByCard();
                SMSNotification();
                LoyaltyPointsAdd();
                Redirect();
            }
        }

        public void PayByCash()
        {
            if (_shop != null)
            {
                _shop.PayByCash();
            }
        }

        public void PayByCheck()
        {
            if (_shop != null)
            {
                _shop.PayByCheck();
            }
        }
    }
}
