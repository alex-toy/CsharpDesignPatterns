namespace FacadePattern.Models
{
    public class NotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
