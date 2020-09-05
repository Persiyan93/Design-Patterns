using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Product coffe = new Coffe("Arabica", 5);
            DecoratorProduct coffewithSugar = new DecoratorProduct(coffe);
            coffewithSugar.AddSugar();
        }
    }
}
