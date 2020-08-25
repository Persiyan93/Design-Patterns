using System;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCreator creator = new CarCreator(new SportCarBuilder());
            creator.CreatVehicle();
            creator.GetCar();
        }
    }
}
