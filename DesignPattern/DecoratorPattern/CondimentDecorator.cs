﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string getDescription();
    }
}
