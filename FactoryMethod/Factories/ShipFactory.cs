using FactoryMethod.Interfaces;
using FactoryMethod.Transports;

namespace FactoryMethod.Factories
{
    internal class ShipFactory : Factory
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
