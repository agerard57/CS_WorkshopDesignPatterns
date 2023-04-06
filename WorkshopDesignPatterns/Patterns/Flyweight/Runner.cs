namespace Patterns.Flyweight
{
    internal class Runner
    {
        public static void Execute()
        {
            FactoryOption factory = new();

            CarOrdered car = new(10000);

            car.AddVehicleOption("Leather seats","Description", 1500, factory);
            car.AddVehicleOption("Navigation system", "Description", 2000, factory);
            car.AddVehicleOption("Sunroof", "Description", 1000, factory);

            car.ShowOptions();

            CarOrdered car2 = new(10000);

            car2.AddVehicleOption("Leather seats", "Description", 1500, factory);
            car2.AddVehicleOption("Navigation system", "Description", 2000, factory);
            car2.AddVehicleOption("Sunroof", "Description", 1000, factory);

            car2.ShowOptions();
        }
    }
}
