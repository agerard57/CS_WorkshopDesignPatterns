namespace Patterns.State
{
    public class Order
    {
        protected List<Product> products;
        protected OrderState state;

        public Order()
        {
            this.state = new OrderInProgress(this);
            this.products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.state.AddProduct(product);
        }

        public void RemoveProduct(Product product)
        {
            this.state.RemoveProduct(product);
        }

        public void ClearList()
        {
            this.state.ClearList();
        }

        public void NextState()
        {
            this.state = this.state.NextState();
        }
    }
}