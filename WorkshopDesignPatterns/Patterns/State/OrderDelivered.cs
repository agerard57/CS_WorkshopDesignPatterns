namespace Patterns.State
{
    public class OrderDelivered : OrderState
    {
        public OrderDelivered(Order order) : base(order)
        {
        }

        public override void AddProduct(Product product)
        {
            Console.WriteLine("Can't add product");
        }

        public override void ClearList()
        {
            Console.WriteLine("The order is already underway");
        }

        public override OrderState NextState()
        {
            Console.WriteLine("Next state");
            return this;
        }

        public override void RemoveProduct(Product product)
        {
            Console.WriteLine("Can't remove product");
        }
    }
}