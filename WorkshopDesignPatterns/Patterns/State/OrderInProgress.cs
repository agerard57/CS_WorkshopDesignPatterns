namespace Patterns.State
{
    public class OrderInProgress : OrderState
    {
        public OrderInProgress(Order order) : base(order)
        {
        }

        public override void AddProduct(Product product)
        {
            Console.WriteLine("Added product " + product.GetName());
        }

        public override void RemoveProduct(Product product)
        {
            Console.WriteLine("Removed product " + product.GetName());
        }

        public override void ClearList()
        {
            Console.WriteLine("Order cancelled");
        }

        public override OrderState NextState()
        {
            return new OrderValidated(this.order);
        }
    }
}