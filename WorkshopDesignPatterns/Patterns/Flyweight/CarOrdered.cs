namespace Patterns.Flyweight
{
    public class CarOrdered
    {
        private float _price;
        private readonly List<VehicleOption> _options = new();

        public CarOrdered(float price = 0)
        {
            _price = price;
        }

        public void AddVehicleOption(string name, string description, float price, FactoryOption factory)
        {
            VehicleOption option = factory.GetOption(name, description, price);
            _options.Add(option);
        }

        public void ShowOptions()
        {
            foreach (VehicleOption option in _options)
            {
                option.Display(_price);
            }
        }

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}