namespace Patterns.Strategy
{
    public class DrawOneVehicle : IDrawCatalogStrategy
    {
        public void Draw(List<string> vehicleNames)
        {
            foreach (string name in vehicleNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}