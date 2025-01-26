namespace OrderWorkshop
{
    public class Order
    {
        private IShippingCostStrategy _shippingCostStrategy;
        private IOrderState _state;
        private NotificationManager _notificationManager;

        public string Status { get; set; }
        public double Amount { get; set; }

        public Order(IShippingCostStrategy shippingCostStrategy)
        {
            _shippingCostStrategy = shippingCostStrategy;
            _notificationManager = new NotificationManager();
            _state = new AcceptedState();
        }

        public void AddNotification(INotification notification)
        {
            _notificationManager.AddNotification(notification);
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Przetwarzanie zamówienia...");

            double shippingCost = _shippingCostStrategy.CalculateShippingCost();
            Console.WriteLine($"Koszt dostawy: {shippingCost} zł");
            Amount += shippingCost;

            _notificationManager.Notify("Zamówienie zostało przetworzone.");

            _state.Handle(this);
        }
    }
}
