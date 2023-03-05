//using VisitorPattern.NotificationSenders;
using VisitorPattern.VisitorNotificationSenders;

namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Before visitor :
            //INotificationSender invoiceNotificationSender = new InvoiceNotificationSender();
            //invoiceNotificationSender.SetUpEmail();
            //invoiceNotificationSender.SetUpText();
            //invoiceNotificationSender.SetUpExcel();
            //invoiceNotificationSender.Send("invoice");

            //INotificationSender marketingNotificationSender = new InvoiceNotificationSender();
            //marketingNotificationSender.SetUpEmail();
            //marketingNotificationSender.SetUpText();
            //marketingNotificationSender.SetUpExcel();
            //marketingNotificationSender.Send("marketing");

            //With visitor :
            EmailVisitor emailVisitor = new EmailVisitor();
            TextVisitor textVisitor = new TextVisitor();
            ExcelVisitor excelVisitor = new ExcelVisitor();

            INotificationSender invoiceNotificationSender = new InvoiceNotificationSender();
            invoiceNotificationSender.Accept(emailVisitor);
            invoiceNotificationSender.Accept(textVisitor);
            invoiceNotificationSender.Accept(excelVisitor);
            invoiceNotificationSender.Send("invoice");

            INotificationSender marketingNotificationSender = new InvoiceNotificationSender();
            marketingNotificationSender.Accept(emailVisitor);
            marketingNotificationSender.Accept(textVisitor);
            marketingNotificationSender.Accept(excelVisitor);
            marketingNotificationSender.Send("marketing");

            System.Console.ReadLine();
        }
    }
}
