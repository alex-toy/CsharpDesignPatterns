using System;
using TemplatePattern.Executors;
using TemplatePattern.templates;

namespace TemplatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var itemValidator = new ItemValidator();   
            var paymentExecutor = new PaymentExecutor();

            var emailReceiptSender = new EmailReceiptSender();
            var cart = new Cart(itemValidator, paymentExecutor, emailReceiptSender);
            cart.Checkout();

            var textReceiptSender = new TextReceiptSender();
            cart = new Cart(itemValidator, paymentExecutor, textReceiptSender);
            cart.Checkout();

            Console.ReadLine();
        }
    }
}
