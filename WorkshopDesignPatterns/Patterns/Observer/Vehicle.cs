namespace Patterns.Observer
{
    public class Vehicle : Subject
    {
        private int price = 0;
        private string description = "";

        public int GetPrice()
        {
            return this.price;
        }

        public void SetPrice(int price)
        {
            this.price = price;
            this.Notify();
        }

        public string GetDescription()
        {
            return this.description;
        }

        public void SetDescription(string description)
        {
            this.description = description;
            this.Notify();
        }
    }
}