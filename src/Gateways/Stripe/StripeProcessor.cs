using balta_desafio_carnacode_2026_1_abstract_factory.Abstractions;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateways.PagSeguro
{
    public class StripeProcessor : IPaymentProcessor
    {
        public string ProcessTransaction(decimal amount, string cardNumber)
        {
            Console.WriteLine($"Stripe: Processing ${amount}...");
            return $"STRIPE-{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
    }
}

