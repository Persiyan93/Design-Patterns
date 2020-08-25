﻿using Factory_Pattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Factory
{
    public class SandwichFactory : IFoodFactory
    {
        public IFood CreateFood()
        {
            return new Sandwich();
        }
    }
}
