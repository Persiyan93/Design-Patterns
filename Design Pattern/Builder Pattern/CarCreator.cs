using Builder_Pattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
   public  class CarCreator
    {
        private IBuilder vehicleBuilder;
        public CarCreator(IBuilder builder)
        {
            this.vehicleBuilder = builder;
        }
        public void CreatVehicle()
        {
            vehicleBuilder.SetModel();
            vehicleBuilder.SetCarWheel();
            vehicleBuilder.SetExhaustSystem();
            vehicleBuilder.SetFuelCapacity();
            vehicleBuilder.SetHorsePower();
        }
        public Car GetCar()
        {
            return vehicleBuilder.GetCar();
        }
    }
}
