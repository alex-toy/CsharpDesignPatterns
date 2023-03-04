namespace BridgePattern.BridgeProcessors
{
    public class EmailNotificationSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email : {message}");
        }
    }
}
