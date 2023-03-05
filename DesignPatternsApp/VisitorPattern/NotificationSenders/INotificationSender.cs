namespace VisitorPattern.NotificationSenders
{
    public interface INotificationSender
    {
        void Send(string message);
        void SetUpEmail();
        void SetUpText();
        void SetUpExcel();
    }
}
