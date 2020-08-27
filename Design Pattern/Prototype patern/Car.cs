using Prototype_patern.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Prototype_patern
{
   public  class Car : ICar

    {
        private Engine engine;
        public Car()
        {

        }
        public Car(Engine engine , int countOfPassenger)
        {
            this.CountOfPassenger = countOfPassenger;
            this.engine = engine;

        }
        public int CountOfPassenger { get; set; }
        public Engine Engine { get=>engine;  }
        public ICar Clone()
        {
            return (ICar)this.MemberwiseClone();
        }
    }
}
