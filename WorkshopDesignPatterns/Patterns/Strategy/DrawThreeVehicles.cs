namespace Patterns.Strategy
{
    public class DrawThreeVehicle : IDrawCatalogStrategy
    {
        public void Draw(List<string> vehiclesNames)
        {
            for (int i = 0; i < vehiclesNames.Count; i += 3)
            {
                Console.WriteLine(string.Join(" | ", vehiclesNames.Skip(i).Take(3)));
            }
        }
    }
}