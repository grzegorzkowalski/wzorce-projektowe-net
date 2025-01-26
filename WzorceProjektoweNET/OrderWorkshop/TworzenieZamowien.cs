// Factory Method Pattern: Tworzenie zamówień
namespace OrderWorkshop
{
    public abstract class OrderFactory
    {
        public abstract Order CreateOrder();
    }

    public class StandardOrderFactory : OrderFactory
    {
        public override Order CreateOrder()
        {
            return new Order(new StandardShippingCost());
        }
    }

    public class ExpressOrderFactory : OrderFactory
    {
        public override Order CreateOrder()
        {
            return new Order(new ExpressShippingCost());
        }
    }

}
