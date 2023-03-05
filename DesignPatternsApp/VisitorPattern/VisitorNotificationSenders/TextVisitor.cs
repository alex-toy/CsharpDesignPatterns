using System;

namespace VisitorPattern.VisitorNotificationSenders
{
    public class TextVisitor : IVisitor
    {
        public void Visit(INotificationSender notificationSender)
        {
            Console.WriteLine("set up text");
        }
    }
}
