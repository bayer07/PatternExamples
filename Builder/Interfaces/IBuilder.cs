namespace Builder.Interfaces
{
    interface IBuilder
    {
        void Reset();
        void BuildWalls();
        void BuildRoof();
        void BuildFloor();
    }
}
