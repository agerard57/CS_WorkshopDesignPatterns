namespace Patterns.Flyweight
{
    public class VehicleOption
    {
        public string Name { get; }
        public string Description { get; }
        public float Price { get; }

        public VehicleOption(string name, string description, float price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

        public void Display(float price)
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Price: " + (Price + price));
        }
    }
}