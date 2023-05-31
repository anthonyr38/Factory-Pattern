using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public void Drive() 
        {
            Console.WriteLine("Zooming on a motorcycle!");
        }
    }
}
