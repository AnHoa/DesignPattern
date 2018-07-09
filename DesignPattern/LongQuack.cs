﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class LongQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack . . . Quack . . . Quack . . .");
        }
    }
}
