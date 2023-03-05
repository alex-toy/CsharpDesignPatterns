using System;

namespace VisitorPattern.VisitorNotificationSenders
{
    internal class EmailVisitor : IVisitor
    {
        public void Visit(INotificationSender notificationSender)
        {
            Console.WriteLine("set up email");
        }
    }
}
