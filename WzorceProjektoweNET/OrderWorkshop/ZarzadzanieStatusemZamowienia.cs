//State Pattern: Zarządzanie statusem zamówienia
namespace OrderWorkshop
{
    public interface IOrderState
    {
        void Handle(Order order);
    }

    public class AcceptedState : IOrderState
    {
        public void Handle(Order order)
        {
            order.Status = "W trakcie realizacji";
            Console.WriteLine("Status zamówienia zmieniony na: W trakcie realizacji");
        }
    }

    public class ProcessingState : IOrderState
    {
        public void Handle(Order order)
        {
            order.Status = "Wysłane";
            Console.WriteLine("Status zamówienia zmieniony na: Wysłane");
        }
    }
}
