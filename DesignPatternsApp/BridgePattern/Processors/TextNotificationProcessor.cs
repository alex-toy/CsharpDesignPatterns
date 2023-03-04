namespace BridgePattern.Processors
{
    public class TextNotificationProcessor : NotificationProcessor
    {
        protected string notificationMessage;

        public override void ProcessNotification(string message)
        {
            notificationMessage = message;
        }
    }
}
