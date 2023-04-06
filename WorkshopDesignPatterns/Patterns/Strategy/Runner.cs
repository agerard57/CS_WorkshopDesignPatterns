namespace Patterns.Strategy
{
    public class Runner
    {
        public static void Execute()
        {
            List<string> vehicleNames = new()
            {
                "Car 1",
                "Car 2",
                "Car 3",
                "Boat 1",
                "Boat 2",
                "Boat 3",
                "Boat 4",
            };

            // Draw catalog with one vehicle per line
            CatalogView catalogView1 = new(new DrawOneVehicle());
            Console.WriteLine("Catalog view with one vehicle per line:");
            catalogView1.Draw(vehicleNames);

            Console.WriteLine();

            // Draw catalog with three vehicles per line
            CatalogView catalogView3 = new(new DrawThreeVehicle());
            Console.WriteLine("Catalog view with three vehicles per line:");
            catalogView3.Draw(vehicleNames);
        }
    }
}