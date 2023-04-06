namespace Patterns.TemplateMethod
{
    public class LuxOrder : AbstractOrder
    {
        public LuxOrder(float costHT) : base(costHT)
        {
        }

        protected override void CalculateTva()
        {
            this.costTva = (this.CostHt * 0.12f) + (this.CostHt * 0.15f);
        }
    }
}