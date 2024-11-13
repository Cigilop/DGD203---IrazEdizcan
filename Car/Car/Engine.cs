namespace FirstGame.Engines
{
    public abstract class Engine : IEngine
    {
        protected float _hp;  
        protected float _fuelConsumptionRate; 
        public bool Running { get; protected set; }

        public Engine(float hp, float fuelConsumptionRate)
        {
            _hp = hp;
            _fuelConsumptionRate = fuelConsumptionRate;
        }

        public virtual void Start()
        {
            Running = true;
            Console.WriteLine("The engine starts running.");
        }

        public void Stop()
        {
            Running = false;
            Console.WriteLine("The engine stops.");
        }

        public bool IsRunning()
        {
            return Running;
        }

        public abstract float CalculateFuelConsumption(float distance);
    }
}
