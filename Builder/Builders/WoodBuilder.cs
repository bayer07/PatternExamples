using System;
using Builder.Houses;
using Builder.Interfaces;

namespace Builder.Builders
{
    class WoodBuilder : IBuilder
    {
        private IHouse house;

        public WoodBuilder()
        {
            house = new WoodHouse();
        }

        public void Reset()
        {
            house = new WoodHouse();
        }

        public void BuildWalls()
        {
            house.Walls = "Wooden walls";
        }

        public void BuildRoof()
        {
            house.Roof = "Wooden roof";
        }

        public void BuildFloor()
        {
            house.Floor = "Wooden floor";
        }

        public void GetResult()
        {
            Console.WriteLine(house.Walls);
            Console.WriteLine(house.Roof);
            Console.WriteLine(house.Floor);
        }
    }
}
