namespace Patterns.State
{
    internal class Runner
    {
        public static void Execute()
        {
            Order order = new();

            order.AddProduct(new Product("Product 1"));

            order.NextState();

            order.NextState();

            order.NextState();
        }
    }
}