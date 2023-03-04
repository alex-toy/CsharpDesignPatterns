namespace BridgePattern.BridgeProcessors
{
    public class TextNotificationProcessor : INotificationProcessor
    {
        private readonly INotificationSender _notificationSender;

        public TextNotificationProcessor(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }

        public void ProcessNotification(string message)
        {
            _notificationSender.SendNotification(message);
        }
    }
}
