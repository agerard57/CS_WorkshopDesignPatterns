namespace Patterns.State
{
    public class OrderValidated : OrderState
    {
        public OrderValidated(Order order) : base(order)
        {
        }

        public override void AddProduct(Product product)
        {
            Console.WriteLine("Product can't be added");
        }

        public override void ClearList()
        {
            Console.WriteLine("Command cancelled");
        }

        public override OrderState NextState()
        {
            return new OrderDelivered(this.order);
        }

        public override void RemoveProduct(Product product)
        {
            Console.WriteLine("Product can't be removed");
        }
    }
}