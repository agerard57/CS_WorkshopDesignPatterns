namespace Patterns.Decorator
{
    public abstract class VehicleViewDecorator : IVehicleGraphicComponent
    {
        protected IVehicleGraphicComponent? component = null;

        public VehicleViewDecorator(IVehicleGraphicComponent component)
        {
            this.component = component;
        }

        public virtual void Display()
        {
            component?.Display();
        }
    }
}