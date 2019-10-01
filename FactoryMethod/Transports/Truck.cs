using System;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Transports
{
    internal class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Do truck deliver");
        }
    }
}
