namespace balta_desafio_carnacode_2026_1_abstract_factory.Abstractions
{
    public interface IPaymentGatewayFactory
    {
        ICardValidator CreateCardValidator();
        IPaymentProcessor CreatePaymentProcessor();
        ITransactionLogger CreateTransactionLogger();
    }
}
