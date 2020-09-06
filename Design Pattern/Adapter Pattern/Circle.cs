using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    public class Circle
    {
        public double CalculateCircularArea(int r)
        {
            return Math.PI * r * r;
        }
    }
}
