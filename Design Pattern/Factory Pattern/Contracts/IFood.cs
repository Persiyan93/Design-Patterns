using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Contracts
{
    public interface IFood
    {
        public int Calories { get; set; }
        public double Grams { get; set; }
    }
}
