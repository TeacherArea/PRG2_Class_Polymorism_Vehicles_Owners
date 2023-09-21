using System;
using System.Runtime.ConstrainedExecution;

namespace Vehicles
{
    class Program
    {
        // Här är ett exempel på polymorfism i klassen Vehicle med ärvda klasser. Analysera det först!
        // Därefter: Klassen Owners har ännu inte använts på något vettigt sätt. Behöver inte fordon en ägare, och det bums?
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car(),
                new Motorcycle(),
                new Volvo(),
                new Peugeot()
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.StartEngine();
            }
        }
    }
}
