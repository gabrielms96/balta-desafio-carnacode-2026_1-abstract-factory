using balta_desafio_carnacode_2026_1_abstract_factory.Abstractions;
using balta_desafio_carnacode_2026_1_abstract_factory.Gateways.PagSeguro;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Factories
{
    public class StripeFactory : IPaymentGatewayFactory
    {
        public ICardValidator CreateCardValidator() => new StripeValidator();

        public IPaymentProcessor CreatePaymentProcessor() => new StripeProcessor();

        public ITransactionLogger CreateTransactionLogger() => new StripeLogger();
    }
}
