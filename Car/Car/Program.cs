using System;

namespace FirstGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle("Volkswagen Golf", "Red", 0f, 50f);

            Console.WriteLine($"Vehicle Model: {myVehicle.Model}, Color: {myVehicle.Color}, Speed: {myVehicle.Speed} km/h, Fuel: {myVehicle.Fuel}%");

            myVehicle.Accelerate(30f); 

            myVehicle.Brake(15f); 

            myVehicle.Refuel(20f); 

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine(); 
        }
    }
}