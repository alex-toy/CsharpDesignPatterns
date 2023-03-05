using System;

namespace VisitorPattern.VisitorNotificationSenders
{
    internal class ExcelVisitor : IVisitor
    {
        public void Visit(INotificationSender notificationSender)
        {
            Console.WriteLine("set up excel");
        }
    }
}
