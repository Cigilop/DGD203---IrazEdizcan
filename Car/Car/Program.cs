using System;
using FirstGame.Engines;

namespace FirstGame
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngine biodieselEngine = new BiodieselEngine(180, 7.5f);

            Car golf = new Car("Volkswagen Golf", "White", biodieselEngine);

            golf.StartCar();

            golf.Accelerate(10, 5);

            float distance = 100;
            float fuelNeeded = biodieselEngine.CalculateFuelConsumption(distance);
            Console.WriteLine($"Fuel needed to drive {distance} km: {fuelNeeded} liters.");

            golf.Refuel(20);

            golf.StopCar();
        }
    }
}
