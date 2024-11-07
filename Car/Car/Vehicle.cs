using System;

namespace FirstGame
{
    public class Vehicle
    {
        public string Model { get; private set; }  
        public float Fuel { get; private set; }   
        public float Speed { get; private set; }   

        public Vehicle(string model, float initialFuel)
        {
            Model = model;  
            Fuel = Math.Clamp(initialFuel, 0f, 100f);  
            Speed = 0f;
        }

        public void Accelerate(float amount)
        {
            if (Fuel > 0)
            {
                Speed += amount;  
                UseFuel(amount / 2f);  
                Console.WriteLine($"{Model} accelerated to {Speed} km/h. Fuel left: {Fuel}%.");  
            }
            else
            {
                Console.WriteLine($"{Model} has no fuel left to accelerate.");
            }
        }

        public void Brake(float amount)
        {
            Speed -= amount;
            if (Speed < 0) Speed = 0;  
            Console.WriteLine($"{Model} slowed down to {Speed} km/h.");
        }

        private void UseFuel(float amount)
        {
            Fuel = Fuel - amount < 0f ? 0f : Fuel - amount;  
        }
    }
}