using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Volvo : Car
    {
        public override void StartEngine()
        {
            Console.WriteLine("Volvo startad");
            base.StartEngine();
        }
    }
}
