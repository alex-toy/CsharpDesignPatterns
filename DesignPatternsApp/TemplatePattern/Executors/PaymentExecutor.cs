using System;
using TemplatePattern.templates;

namespace TemplatePattern.Executors
{
    public class PaymentExecutor : IPaymentExecutor
    {
        public void ExecutePayment()
        {
            Console.WriteLine("payment executed");
        }
    }
}
