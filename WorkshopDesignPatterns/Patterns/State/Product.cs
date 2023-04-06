namespace Patterns.State
{
    public class Product
    {
        private string name;

        public Product(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}