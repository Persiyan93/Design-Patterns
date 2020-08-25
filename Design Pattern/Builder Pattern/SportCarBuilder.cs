using Builder_Pattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class SportCarBuilder : IBuilder
    {
        private Car car;

        public Car GetCar()
        {
            return this.car;
        }

        public void SetCarWheel()
        {
            this.car.WheelModel = "Oz";
        }

        public void SetExhaustSystem()
        {
            this.car.ExhaustSystem = "Stock";
        }

        public void SetFuelCapacity()
        {
            this.car.ExhaustSystem = "100";
        }

        public void SetHorsePower()
        {
            this.car.Horsepower = 150;
        }

        public void SetModel()
        {
            this.car.Model = "Sport";
        }
    }
}
