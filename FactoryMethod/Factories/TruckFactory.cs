using FactoryMethod.Interfaces;
using FactoryMethod.Transports;

namespace FactoryMethod.Factories
{
    internal class TruckFactory : Factory
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
