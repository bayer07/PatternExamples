using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}
