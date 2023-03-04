namespace FacadePattern.Models
{
    public class PaymentService : IPaymentService
    {
        public void Pay(double amount, string item)
        {
            Console.WriteLine($"paying {amount} dollars for {item}");
        }
    }
}
