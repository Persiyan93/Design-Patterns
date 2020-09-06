using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    public class Square : IShape
    {
        public int CalculateArea(int r)
        {
            return r * r;
        }
    }
}
