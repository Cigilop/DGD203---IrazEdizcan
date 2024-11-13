namespace FirstGame
{
    public class Car : Vehicle
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public float Speed { get; private set; }  
        private IEngine _engine;

        public Car(string model, string color, IEngine engine)
        {
            Model = model;
            Color = color;
            _engine = engine;
            Speed = 0;  
        }

        public void Accelerate(float acceleration, float time)
        {
            if (_engine.IsRunning())
            {
                Speed += acceleration * time;
                Console.WriteLine($"{Model} is accelerating. Speed: {Speed} km/h.");
            }
            else
            {
                Console.WriteLine("Start the engine before accelerating.");
            }
        }

        public void StartCar()
        {
            if (_engine != null)
            {
                _engine.Start();
                Console.WriteLine($"Car {Model} has started with {_engine.GetType().Name}.");
            }
        }

        public void StopCar()
        {
            if (_engine.IsRunning())
            {
                _engine.Stop();
                Console.WriteLine($"Car {Model} has stopped.");
                Speed = 0; 
            }
        }
    }
}
