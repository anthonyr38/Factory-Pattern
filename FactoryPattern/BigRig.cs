using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BigRig : IVehicle
    {
        public string Color { get; set; }
        public bool HasFogLights { get; set; }

        public void Drive() 
        {
            Console.WriteLine("Cruising the Big Rig");
        }
    }
}
