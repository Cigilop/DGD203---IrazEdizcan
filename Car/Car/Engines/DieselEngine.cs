namespace FirstGame.Engines
{
    public class DieselEngine : Engine
    {
        public DieselEngine(float hp, float fuelConsumptionRate) : base(hp, fuelConsumptionRate)
        {
        }

        public override float CalculateFuelConsumption(float distance)
        {
            return (_fuelConsumptionRate / 100) * distance;
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine($"Diesel engine with {_hp} HP is now running.");
        }
    }
}