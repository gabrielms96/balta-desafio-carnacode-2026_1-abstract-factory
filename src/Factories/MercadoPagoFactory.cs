using balta_desafio_carnacode_2026_1_abstract_factory.Abstractions;
using balta_desafio_carnacode_2026_1_abstract_factory.Gateways.MercadoPago;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Factories
{
    internal class MercadoPagoFactory : IPaymentGatewayFactory
    {
        public ICardValidator CreateCardValidator() => new MercadoPagoValidator();

        public IPaymentProcessor CreatePaymentProcessor() => new MercadoPagoProcessor();

        public ITransactionLogger CreateTransactionLogger() => new MercadoPagoLogger();
    }
}
