using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
   public class Tea:Product
    {
        public Tea(string name,decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
