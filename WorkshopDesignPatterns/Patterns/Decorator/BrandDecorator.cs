namespace Patterns.Decorator
{
    public class BrandDecorator : VehicleViewDecorator
    {
        protected string brand;

        public BrandDecorator(IVehicleGraphicComponent component, string brand) : base(component)
        {
            this.brand = brand;
        }

        public void DisplayBrand()
        {
            Console.WriteLine("- Vehicle brand: " + brand);
        }

        public override void Display()
        {
            base.Display();
            this.DisplayBrand();
        }
    }
}