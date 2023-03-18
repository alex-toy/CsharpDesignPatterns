namespace TemplatePattern.templates
{
    public class Cart
    {
        private readonly IPaymentExecutor _paymentExecutor;
        private readonly IReceiptSender _receiptSender;
        private readonly IItemValidator _itemValidator;

        public Cart(IItemValidator itemValidator, IPaymentExecutor paymentExecutor, IReceiptSender receiptSender)
        {
            _itemValidator = itemValidator;
            _paymentExecutor = paymentExecutor;
            _receiptSender = receiptSender;
        }

        public void Checkout()
        {
            _itemValidator.Validate();
            _paymentExecutor.ExecutePayment();
            _receiptSender.SendReceipt();
        }
    }
}
