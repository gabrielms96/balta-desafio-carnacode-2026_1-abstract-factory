using balta_desafio_carnacode_2026_1_abstract_factory.Abstractions;
using balta_desafio_carnacode_2026_1_abstract_factory.Gateways.PagSeguro;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Factories
{
    public class PagSeguroFactory : IPaymentGatewayFactory
    {
        public ICardValidator CreateCardValidator() => new PagSeguroValidator();

        public IPaymentProcessor CreatePaymentProcessor() => new PagSeguroProcessor();

        public ITransactionLogger CreateTransactionLogger() => new PagSeguroLogger();
    }
}
