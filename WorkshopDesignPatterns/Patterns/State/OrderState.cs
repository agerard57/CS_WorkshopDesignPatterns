namespace Patterns.State
{
    public abstract class OrderState
    {
        protected Order order;

        public OrderState(Order order)
        {
            this.order = order;
        }

        public abstract void AddProduct(Product product);

        public abstract void RemoveProduct(Product product);

        public abstract void ClearList();

        public abstract OrderState NextState();
    }
}