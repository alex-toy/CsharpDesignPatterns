using System;

namespace VisitorPattern.VisitorNotificationSenders
{
    public class InvoiceNotificationSender : INotificationSender
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Send(string message)
        {
            Console.WriteLine($"Send notification : {message}");
        }
    }
}
