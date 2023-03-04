namespace BridgePattern.Processors
{
    public class TextNotificationSender : TextNotificationProcessor
    {
        public override void ProcessNotification(string message)
        {
            base.ProcessNotification(message);

            Console.WriteLine($"Text : {notificationMessage}");
        }
    }
}
