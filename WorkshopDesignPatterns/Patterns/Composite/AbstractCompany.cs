namespace Patterns.Composite
{
    internal abstract class AbstractCompany
    {
        protected List<string> vehicles = new();

        public void AddVehicle(string name)
        {
            vehicles.Add(name);
        }

        public abstract int CalculateMaintenanceCost();
    }
}