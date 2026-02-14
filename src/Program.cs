using balta_desafio_carnacode_2026_1_abstract_factory.Abstractions;
using balta_desafio_carnacode_2026_1_abstract_factory.Factories;
using balta_desafio_carnacode_2026_1_abstract_factory.Services;

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
            Console.WriteLine("Payment initiated with PagSeguro...");

            IPaymentGatewayFactory pagSeguroFactory = new PagSeguroFactory();
            var pagSeguroService = new PaymentService(pagSeguroFactory);

            string cardNumber = "1234567890123456";
            decimal amount = 150.00m;

            pagSeguroService.ProcessPayment(amount, cardNumber);

            Console.WriteLine("Payment completed via PagSeguro...");
            Console.WriteLine("-----------------------------------");
        }

        public static void ExecuteMercadoPagoPayment()
        {
            Console.WriteLine("Payment initiated with MercadoPago...");

            IPaymentGatewayFactory mercadoPagoFactory = new MercadoPagoFactory();
            var mercadoPagoService = new PaymentService(mercadoPagoFactory);

            string cardNumber = "5234567890123456";
            decimal amount = 200.00m;

            mercadoPagoService.ProcessPayment(amount, cardNumber);

            Console.WriteLine("Payment completed via MercadoPago...");
            Console.WriteLine("-----------------------------------");
        }

        public static void ExecuteStripePayment()
        {
            Console.WriteLine("Payment initiated with Stripe...");

            IPaymentGatewayFactory stripeFactory = new StripeFactory();
            var stripeService = new PaymentService(stripeFactory);

            string cardNumber = "4234567890123456";
            decimal amount = 250.00m;

            stripeService.ProcessPayment(amount, cardNumber);

            Console.WriteLine("Payment completed via Stripe...");
            Console.WriteLine("-----------------------------------");
        }
    }
}