using balta_desafio_carnacode_2026_1_abstract_factory.Abstractions;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateways.PagSeguro
{
    public class StripeLogger : ITransactionLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
        }
    }
}
