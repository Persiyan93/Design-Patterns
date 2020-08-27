using Prototype_patern.Contracts;
using System;
using System.Diagnostics.Contracts;

namespace Prototype_patern
{
    public class Program
    {

        static void Main()
        {
            Engine engine = new Engine(10);
            Car mycar = new Car(engine, 10);

            ICar copyCar = mycar.Clone();
            Console.WriteLine(copyCar.CountOfPassenger);

        }

    }
}
