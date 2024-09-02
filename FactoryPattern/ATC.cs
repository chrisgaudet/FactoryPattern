using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ATC : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The atc has 3 wheels.");
        }
    }
}
