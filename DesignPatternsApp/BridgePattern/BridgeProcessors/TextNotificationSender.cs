namespace BridgePattern.BridgeProcessors
{
    public class TextNotificationSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Text : {message}");
        }
    }
}
