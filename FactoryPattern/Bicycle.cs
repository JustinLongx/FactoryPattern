using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Bicycle : IVehicle
    {
        public void drive()
        {
            Console.WriteLine("Riding a Bicycle!");
        }
    }
}
