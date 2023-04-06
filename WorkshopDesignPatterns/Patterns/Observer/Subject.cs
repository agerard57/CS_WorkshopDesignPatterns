namespace Patterns.Observer
{
    public class Subject
    {
        protected List<IObserver> observers = new();

        public void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Notify();
            }
        }
    }
}