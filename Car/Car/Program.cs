using FirstGame;

class Program
{
    static void Main(string[] args)
    {
        Vehicle myVehicle = new Vehicle("Toyota Corolla", 50f);

        myVehicle.Accelerate(20f);
        myVehicle.Brake(10f);
        myVehicle.Accelerate(15f);
    }
}