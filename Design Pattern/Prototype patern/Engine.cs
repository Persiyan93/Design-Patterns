using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_patern
{
    public class Engine
    {
        public Engine(int horsePower)
        {
            this.HorsePower = horsePower;
        }
        public int HorsePower { get; set; }
        public void Horsepower()
        {
            Console.Write(this.HorsePower);
        }
    }
}
