namespace Patterns.TemplateMethod
{
    public abstract class AbstractOrder
    {
        protected float costHt;
        protected float costTva;
        protected float costTtc;

        public AbstractOrder(float costHt)
        {
            this.costHt = costHt;
        }

        public void Display()
        {
            Console.WriteLine("- HT: " + costHt);
            Console.WriteLine("- TVA: " + costTva);
            Console.WriteLine("- TTC: " + costTtc);
        }

        public void CalculateCosts()
        {
            CalculateTva();
            costTtc = costHt + costTva;
        }

        protected abstract void CalculateTva();

        protected float CostHt
        { get { return costHt; } }

        protected float CostTva
        { get { return costTva; } }

        protected float CostTtc
        { get { return costTtc; } }
    }
}