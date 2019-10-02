using Builder.Interfaces;

namespace Builder.Houses
{
    class WoodHouse : IHouse
    {
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Floor { get; set; }
    }
}
