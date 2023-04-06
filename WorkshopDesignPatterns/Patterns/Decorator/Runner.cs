namespace Patterns.Decorator
{
    public class Runner
    {
        public static void Execute()
        {
            IVehicleGraphicComponent vehicle = new VehicleView();

            vehicle = new BrandDecorator(vehicle, "Renault");
            vehicle = new ModelDecorator(vehicle, "Megane");

            vehicle.Display();
        }
    }
}