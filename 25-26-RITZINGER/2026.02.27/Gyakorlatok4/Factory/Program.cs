using Factory.CreditCard;
using Factory.Framework;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory.Framework.Factory factory = new CreditCardFactory();

            IProduct jacksonCard = factory.Create("Jackson");
            jacksonCard.Use();

            IProduct sophiaCard = factory.Create("Sophia");
            sophiaCard.Use();

            IProduct oliviaCard = factory.Create("Olivia");
            oliviaCard.Use();
        }
    }
}
