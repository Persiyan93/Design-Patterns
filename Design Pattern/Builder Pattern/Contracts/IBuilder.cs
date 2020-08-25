using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Contracts
{
    public interface IBuilder 
        
    {
        public void SetModel();
        public void SetHorsePower();
        public void SetExhaustSystem();
        public void SetFuelCapacity();
        public Car GetCar();
        public void SetCarWheel();

    }
}
