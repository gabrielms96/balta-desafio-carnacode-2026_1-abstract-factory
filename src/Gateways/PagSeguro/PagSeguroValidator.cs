using balta_desafio_carnacode_2026_1_abstract_factory.Abstractions;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateways.PagSeguro
{
    public class PagSeguroValidator : ICardValidator
    {
        public bool ValidateCard(string cardNumber)
        {
            Console.WriteLine("PagSeguro: Validating card...");
            return cardNumber.Length == 16;
        }
    }
}
