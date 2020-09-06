using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    public class CircleAdapter : Circle, IShape
    {
        public int CalculateArea(int r)
        {
            return (int)this.CalculateCircularArea(r);
        }
    }
}
