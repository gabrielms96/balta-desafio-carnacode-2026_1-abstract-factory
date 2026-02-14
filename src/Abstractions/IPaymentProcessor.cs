namespace balta_desafio_carnacode_2026_1_abstract_factory.Abstractions
{
    public interface IPaymentProcessor
    {
        string ProcessTransaction(decimal amount, string cardNumber);
    }
}
