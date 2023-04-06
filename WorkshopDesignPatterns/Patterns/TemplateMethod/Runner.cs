namespace Patterns.TemplateMethod
{
    internal class Runner
    {
        private const float TestValue = 10;

        public static void Execute()
        {
            Console.WriteLine(TestValue + " euros - French:");
            var frOrder = new FrOrder(TestValue);
            frOrder.CalculateCosts();
            frOrder.Display();

            Console.WriteLine("\n" + TestValue + " euros - Luxembourg:");
            var luxOrder = new LuxOrder(TestValue);
            luxOrder.CalculateCosts();
            luxOrder.Display();
        }
    }
}