namespace Patterns.Command
{
    internal class Runner
    {
        public static void Execute()
        {
            Vehicle car1 = new(DateTime.Now.AddDays(-30), 20000);
            Vehicle car2 = new(DateTime.Now.AddDays(-15), 25000);
            Vehicle car3 = new(DateTime.Now.AddDays(-10), 30000);

            Catalog catalog = new();
            catalog.AddVehicle(car1);
            catalog.AddVehicle(car2);
            catalog.AddVehicle(car3);

            OrderDiscount orderDiscount = new(20);

            catalog.RunSaleOrder(orderDiscount);

            Console.WriteLine("Prices after discount:");
            foreach (Vehicle vehicle in catalog.vehicles)
            {
                Console.WriteLine($"Price: {vehicle.price} euros");
            }

            Catalog.UndoSaleOrder(orderDiscount);

            Console.WriteLine("Prices after undo:");
            foreach (Vehicle vehicle in catalog.vehicles)
            {
                Console.WriteLine($"Price: {vehicle.price} euros");
            }
        }
    }
}