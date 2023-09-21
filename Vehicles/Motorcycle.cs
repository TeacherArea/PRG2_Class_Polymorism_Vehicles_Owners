using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Motorcykel startad");
            base.StartEngine();
        }
    }
}
