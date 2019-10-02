using Builder.Builders;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var woodBuilder = new WoodBuilder();
            woodBuilder.BuildFloor();
            woodBuilder.BuildWalls();
            woodBuilder.BuildRoof();
            woodBuilder.GetResult();

            var concreteBuilder = new ConcreteBuilder();
            concreteBuilder.BuildFloor();
            concreteBuilder.BuildWalls();
            concreteBuilder.BuildRoof();
            concreteBuilder.GetResult();
        }
    }
}
