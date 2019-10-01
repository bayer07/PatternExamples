﻿using AbstractFactory.Interfaces;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    class Factory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
