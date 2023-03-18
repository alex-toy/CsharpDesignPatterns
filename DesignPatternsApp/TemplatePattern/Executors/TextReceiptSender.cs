using System;
using TemplatePattern.templates;

namespace TemplatePattern.Executors
{
    public class TextReceiptSender : IReceiptSender
    {
        public void SendReceipt()
        {
            Console.WriteLine("text receipt sent");
        }
    }
}
