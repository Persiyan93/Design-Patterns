using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Contracts
{
    public interface IFoodFactory
    {
        public abstract IFood CreateFood();

    }
}
