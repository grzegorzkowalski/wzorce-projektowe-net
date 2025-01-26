// Observer Pattern: Powiadomienia
namespace OrderWorkshop
{
    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Wysyłanie powiadomienia e-mail: " + message);
        }
    }

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Wysyłanie powiadomienia SMS: " + message);
        }
    }

    public class NotificationManager
    {
        private List<INotification> _notifications = new List<INotification>();

        public void AddNotification(INotification notification)
        {
            _notifications.Add(notification);
        }

        public void Notify(string message)
        {
            foreach (var notification in _notifications)
            {
                notification.Send(message);
            }
        }
    }
}
