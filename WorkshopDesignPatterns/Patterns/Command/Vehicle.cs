namespace Patterns.Command
{
    public class Vehicle
    {
        public DateTime stockEntryTimestamp;
        public float price;

        public Vehicle(DateTime stockEntryTimestamp, float price)
        {
            this.stockEntryTimestamp = stockEntryTimestamp;
            this.price = price;
        }

        public int GetStorageDuration()
        {
            return (int)(DateTime.Now - this.stockEntryTimestamp).TotalDays;
        }

        public void EditPrice(float coef)
        {
            this.price *= (1 - (coef / 100));
        }
    }
}