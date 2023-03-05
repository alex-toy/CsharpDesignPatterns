using System;

namespace VisitorPattern.NotificationSenders
{
    public class MarketingNotificationSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Send notification : {message}");
        }

        public void SetUpEmail()
        {
            Console.WriteLine("set up email");
        }

        public void SetUpExcel()
        {
            Console.WriteLine("set up excel");
        }

        public void SetUpText()
        {
            Console.WriteLine("set up text");
        }
    }
}
