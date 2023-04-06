namespace Patterns.Decorator
{
    public class VehicleView : IVehicleGraphicComponent
    {
        public void Display()
        {
            Console.WriteLine("Car");
        }
    }
}