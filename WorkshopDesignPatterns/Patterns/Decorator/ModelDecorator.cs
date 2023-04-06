namespace Patterns.Decorator
{
    public class ModelDecorator : VehicleViewDecorator
    {
        public string Model { get; }

        public ModelDecorator(IVehicleGraphicComponent component, string model) : base(component)
        {
            Model = model;
        }

        public override void Display()
        {
            base.Display();
            DisplayInfos();
        }

        protected virtual void DisplayInfos()
        {
            Console.WriteLine("- Vehicle model: " + Model);
        }
    }
}