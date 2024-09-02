﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorbike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The motorbike is revving its engine");
            Console.WriteLine("Vrooom, Vrooom.");
        }
    }
}
