﻿using Factory_Pattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Pizza : IFood
    {
        public int Calories { get; set; }
        public double Grams { get; set; }
    }
}
