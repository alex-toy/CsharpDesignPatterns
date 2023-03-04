namespace FacadePattern.Models
{
    public interface IPaymentService
    {
        void Pay(double amount, string item);
    }
}
