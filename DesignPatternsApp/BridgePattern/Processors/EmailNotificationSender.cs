namespace BridgePattern.Processors
{
    public class EmailNotificationSender : TextNotificationProcessor
    {
        public override void ProcessNotification(string message)
        {
            base.ProcessNotification(message);

            Console.WriteLine($"Email : {notificationMessage}");
        }
    }
}
