using Builder.Interfaces;

namespace Builder.Houses
{
    class ConcreteHouse : IHouse
    {
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Floor { get; set; }
    }
}
