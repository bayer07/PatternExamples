using System;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Transports
{
    internal class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Do ship deliver");
        }
    }
}
