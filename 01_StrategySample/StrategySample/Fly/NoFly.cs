﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategySample.Fly
{
    public class NoFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("---");
        }
    }
}
