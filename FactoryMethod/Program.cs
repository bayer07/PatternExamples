using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var truck = new TruckFactory();
            var ship = new ShipFactory();

            truck.Deliver();
            ship.Deliver();
        }
    }
}
