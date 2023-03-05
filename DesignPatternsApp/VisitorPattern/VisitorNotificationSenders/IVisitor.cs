namespace VisitorPattern.VisitorNotificationSenders
{
    public interface IVisitor
    {
        void Visit(INotificationSender notificationSender);
    }
}