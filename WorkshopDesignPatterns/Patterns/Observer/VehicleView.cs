namespace Patterns.Observer
{
    public class VehicleView : IObserver
    {
        protected Vehicle subject;

        public VehicleView(Vehicle subject)
        {
            this.subject = subject;
            Display();
        }

        public void Notify()
        {
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Price: " + subject.GetPrice() + " euros");
            Console.WriteLine("Car Description: " + subject.GetDescription());
        }
    }
}