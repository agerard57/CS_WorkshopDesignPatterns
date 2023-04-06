namespace Patterns.TemplateMethod
{
    public class FrOrder : AbstractOrder
    {
        public FrOrder(float costHT) : base(costHT)
        {
        }

        protected override void CalculateTva()
        {
            this.costTva = this.CostHt * 0.196f;
        }
    }
}