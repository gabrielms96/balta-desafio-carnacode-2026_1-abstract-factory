using balta_desafio_carnacode_2026_1_abstract_factory.Abstractions;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateways.MercadoPago
{
    public class MercadoPagoValidator : ICardValidator
    {
        public bool ValidateCard(string cardNumber)
        {
            Console.WriteLine("MercadoPago: Validating card...");
            return cardNumber.Length == 16 && cardNumber.StartsWith("5");
        }
    }
}
