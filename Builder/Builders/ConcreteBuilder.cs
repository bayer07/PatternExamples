using System;
using Builder.Houses;
using Builder.Interfaces;

namespace Builder.Builders
{
    class ConcreteBuilder : IBuilder
    {
        private IHouse house;

        public ConcreteBuilder()
        {
            house = new ConcreteHouse();
        }

        public void Reset()
        {
            house = new ConcreteHouse();
        }

        public void BuildWalls()
        {
            house.Walls = "Concrete walls";
        }

        public void BuildRoof()
        {
            house.Roof = "Concrete roof";
        }

        public void BuildFloor()
        {
            house.Floor = "Concrete floor";
        }

        public void GetResult()
        {
            Console.WriteLine(house.Walls);
            Console.WriteLine(house.Roof);
            Console.WriteLine(house.Floor);
        }
    }
}
