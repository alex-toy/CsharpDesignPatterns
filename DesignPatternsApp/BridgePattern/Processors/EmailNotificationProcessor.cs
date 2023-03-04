namespace BridgePattern.Processors
{
    public class EmailNotificationProcessor : NotificationProcessor
    {
        protected string notificationMessage;

        public override void ProcessNotification(string message)
        {
            notificationMessage = $"<html>{message}</html>";
        }
    }
}
