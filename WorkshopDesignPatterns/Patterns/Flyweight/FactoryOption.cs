namespace Patterns.Flyweight
{
    public class FactoryOption
    {
        private readonly Dictionary<string, VehicleOption> options = new();

        public VehicleOption GetOption(string name, string description, float price)
        {
            if (options.ContainsKey(name))
                return options[name];

            VehicleOption newOption = new(name, description, price);
            options.Add(name, newOption);
            return newOption;
        }
    }
}