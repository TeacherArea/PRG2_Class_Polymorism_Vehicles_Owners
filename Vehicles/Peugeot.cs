using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Peugeot : Car
    {
        public override void StartEngine()
        {
            Console.WriteLine("Peugeot startad");
            base.StartEngine();
        }
    }
}
