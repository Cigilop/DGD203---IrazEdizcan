namespace FirstGame
{
    public class Vehicle
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public float Speed { get; private set; }  
        public float Fuel { get; private set; }   

        public Vehicle(string model, string color, float speed, float fuel)
        {
            Model = model;
            Color = color;
            Speed = Math.Clamp(speed, 0f, 200f);  
            Fuel = Math.Clamp(fuel, 0f, 100f);    
        }

        public void Accelerate(float amount)
        {
            Speed = Math.Clamp(Speed + amount, 0f, 200f);  
            UseFuel(amount / 2f);  
            Console.WriteLine($"{Model} accelerated to {Speed} km/h. Fuel left: {Fuel}%");
        }

        public void Brake(float amount)
        {
            Speed = Math.Max(Speed - amount, 0f);  
            Console.WriteLine($"{Model} slowed down to {Speed} km/h.");
        }

        public void UseFuel(float amount)
        {
            Fuel = Math.Max(Fuel - amount, 0f);  
        }

        public void Refuel(float amount)
        {
            Fuel = Math.Clamp(Fuel + amount, 0f, 100f);  
            Console.WriteLine($"{Model} refueled. Fuel level is now {Fuel}%.");
        }
    }
}
