using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories
{
    internal abstract class Factory
    {
        protected Factory()
        {
            _transport = CreateTransport();
        }

        readonly ITransport _transport;

        public void Deliver()
        {
            _transport.Deliver();
        }

        public abstract ITransport CreateTransport();
    }
}
