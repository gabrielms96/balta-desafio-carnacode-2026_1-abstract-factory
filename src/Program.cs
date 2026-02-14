using balta_desafio_carnacode_2026_1_abstract_factory.Factories;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateways.MercadoPago
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteMercadoPagoPayment();

            ExecutePagSeguroPayment();

            ExecuteStripePayment();
        }

        public static void ExecutePagSeguroPayment()
        {
            Console.WriteLine("Processing payment with PagSeguro...");

            var factory = new PagSeguroFactory();
            var cardValidator = factory.CreateCardValidator();
            var paymentProcessor = factory.CreatePaymentProcessor();
            var transactionLogger = factory.CreateTransactionLogger();
            string cardNumber = "1234567890123456";
            decimal amount = 150.00m;
            if (cardValidator.ValidateCard(cardNumber))
            {
                string transactionId = paymentProcessor.ProcessTransaction(amount, cardNumber);
                transactionLogger.Log($"Transaction successful: {transactionId}");
            }
            else
            {
                transactionLogger.Log("Transaction failed: Invalid card number.");
            }
        }

        public static void ExecuteMercadoPagoPayment()
        {
            Console.WriteLine("Processing payment with MercadoPago...");

            var factory = new MercadoPagoFactory();
            var cardValidator = factory.CreateCardValidator();
            var paymentProcessor = factory.CreatePaymentProcessor();
            var transactionLogger = factory.CreateTransactionLogger();
            string cardNumber = "5234567890123456";
            decimal amount = 200.00m;
            if (cardValidator.ValidateCard(cardNumber))
            {
                string transactionId = paymentProcessor.ProcessTransaction(amount, cardNumber);
                transactionLogger.Log($"Transaction successful: {transactionId}");
            }
            else
            {
                transactionLogger.Log("Transaction failed: Invalid card number.");
            }
        }

        public static void ExecuteStripePayment()
        {
            Console.WriteLine("Processing payment with Stripe...");

            var factory = new StripeFactory();
            var cardValidator = factory.CreateCardValidator();
            var paymentProcessor = factory.CreatePaymentProcessor();
            var transactionLogger = factory.CreateTransactionLogger();
            string cardNumber = "4234567890123456";
            decimal amount = 250.00m;
            if (cardValidator.ValidateCard(cardNumber))
            {
                string transactionId = paymentProcessor.ProcessTransaction(amount, cardNumber);
                transactionLogger.Log($"Transaction successful: {transactionId}");
            }
            else
            {
                transactionLogger.Log("Transaction failed: Invalid card number.");
            }
        }
    }
}







