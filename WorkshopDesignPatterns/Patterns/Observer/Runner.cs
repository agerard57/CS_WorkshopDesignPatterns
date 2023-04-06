namespace Patterns.Observer
{
    internal class Runner
    {
        public static void Execute()
        {
            Vehicle vehicle = new();
            vehicle.SetPrice(10000);
            vehicle.SetDescription("This is a car");
            VehicleView view1 = new(vehicle);
        }
    }
}