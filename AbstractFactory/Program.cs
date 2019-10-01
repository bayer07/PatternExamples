using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory1 = new Factory1();
            var factory2 = new Factory2();

            var productA1 = factory1.CreateProductA();
            var productB1 = factory1.CreateProductB();

            var productA2 = factory2.CreateProductA();
            var productB2 = factory2.CreateProductB();

            Console.WriteLine(productA1.Name);
            Console.WriteLine(productB1.Type);

            Console.WriteLine(productA2.Name);
            Console.WriteLine(productB2.Type);
        }
    }
}
