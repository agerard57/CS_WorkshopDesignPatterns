namespace Patterns.Command
{
    public class OrderDiscount
    {
        private readonly int discountRate;
        private readonly List<Vehicle> discountVehicles = new();

        public OrderDiscount(int discountRate)
        {
            this.discountRate = discountRate;
        }

        public void MakeDiscount(List<Vehicle> vehicles)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                discountVehicles.Add(vehicle);
                vehicle.EditPrice(discountRate);
            }
        }

        public void Undo()
        {
            foreach (Vehicle vehicle in discountVehicles)
            {
                vehicle.EditPrice(-discountRate);
            }
            discountVehicles.Clear();
        }
    }
}