namespace Patterns.Command
{
    public class Catalog
    {
        public List<Vehicle> vehicles = new();

        public void RunSaleOrder(OrderDiscount orderDiscount)
        {
            orderDiscount.MakeDiscount(vehicles);
        }

        public static void UndoSaleOrder(OrderDiscount orderDiscount)
        {
            orderDiscount.Undo();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }
    }
}