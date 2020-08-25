using Factory_Pattern.Contracts;
using Factory_Pattern.Factory;
using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFoodFactory pizzaFactory = new PizzaFactory();
            IFoodFactory sandwichFactory = new SandwichFactory();
            IFood pizza = pizzaFactory.CreateFood();
            IFood sandwich = sandwichFactory.CreateFood();
        }
    }
}
