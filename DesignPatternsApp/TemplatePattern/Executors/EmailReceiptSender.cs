using System;
using TemplatePattern.templates;

namespace TemplatePattern.Executors
{
    public class EmailReceiptSender : IReceiptSender
    {
        public void SendReceipt()
        {
            Console.WriteLine("email receipt sent");
        }
    }
}
