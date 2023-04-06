namespace Patterns.Strategy
{
    public class CatalogView
    {
        private readonly IDrawCatalogStrategy? _drawStrategy;

        public CatalogView(IDrawCatalogStrategy drawStrategy)
        {
            _drawStrategy = drawStrategy;
        }

        public void Draw(List<string> vehicleNames)
        {
            if (_drawStrategy == null)
            {
                throw new InvalidOperationException("Draw strategy cannot be null.");
            }

            _drawStrategy.Draw(vehicleNames);
        }
    }
}