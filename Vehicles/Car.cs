using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bil startad");
            base.StartEngine();
        }
    }
}
