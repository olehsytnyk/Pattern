﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategySample.Fly
{
    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with my wings");
        }
    }
}
