namespace FirstGame
{
    public class PhysicsCalculator
    {
        public static double CalculateAcceleration(double force, double mass)
        {
            return force / mass;
        }

        public static double CalculateSpeed(double acceleration, double time)
        {
            return acceleration * time;
        }
    }
}
