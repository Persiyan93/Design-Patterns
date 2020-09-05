using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class Coffe:Product
    {
        public Coffe(string name,decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
