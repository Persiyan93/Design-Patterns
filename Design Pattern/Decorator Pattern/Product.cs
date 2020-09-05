using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Volume { get; set; }

    }
}
