using balta_desafio_carnacode_2026_1_abstract_factory.Abstractions;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Services
{
    public class PaymentService
    {
        private readonly IPaymentGatewayFactory _factory;

        public PaymentService(IPaymentGatewayFactory factory)
        {
            _factory = factory;
        }

        public void ProcessPayment(decimal amount, string cardNumber)
        {
            var validator = _factory.CreateCardValidator();
            if (!validator.ValidateCard(cardNumber))
            {
                Console.WriteLine("Invalid card");
                return;
            }

            var processor = _factory.CreatePaymentProcessor();
            var result = processor.ProcessTransaction(amount, cardNumber);

            var logger = _factory.CreateTransactionLogger();
            logger.Log($"Transaction processed: {result}");
        }
    }
}
