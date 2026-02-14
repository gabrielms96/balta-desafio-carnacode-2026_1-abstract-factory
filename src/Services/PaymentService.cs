using balta_desafio_carnacode_2026_1_abstract_factory.Abstractions;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Services
{
    /// <summary>
    /// Provides functionality for processing payments.
    /// </summary>
    public class PaymentService
    {
        private readonly IPaymentGatewayFactory _factory;

        /// <summary>
        /// Initializes a new instance of the PaymentService class using the specified payment gateway factory.
        /// </summary>
        /// <param name="factory">The factory used to create payment gateway instances.</param>
        public PaymentService(IPaymentGatewayFactory factory)
        {
            _factory = factory;
        }

        /// <summary>
        /// Processes a payment by validating the card and executing the transaction.
        /// </summary>
        /// <param name="amount">The amount to be charged.</param>
        /// <param name="cardNumber">The credit card number to be used for the payment.</param>
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
