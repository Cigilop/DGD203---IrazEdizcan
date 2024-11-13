namespace FirstGame.Engines
{
    public class BiodieselEngine : DieselEngine
    {
        public BiodieselEngine(float hp, float fuelConsumptionRate) : base(hp, fuelConsumptionRate)
        {
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("The biodiesel engine starts running.");
        }
    }
}