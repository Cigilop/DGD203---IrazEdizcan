namespace FirstGame
{
    public abstract class Vehicle
    {
        public float Fuel { get; protected set; }

        public void Refuel(float amount)
        {
            Fuel += amount;
            Console.WriteLine($"Vehicle refueled with {amount} liters. Total fuel: {Fuel} liters.");
        }
    }
}
