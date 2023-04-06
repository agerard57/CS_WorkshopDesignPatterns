namespace Patterns.Composite
{
    internal class ParentCompany : AbstractCompany
    {
        protected List<AbstractCompany> branches = new();

        public override int CalculateMaintenanceCost()
        {
            int maintenanceCost = 10;
            foreach (string vehicle in vehicles)
            {
                maintenanceCost += 1;
                Console.WriteLine("Maintenance cost for " + vehicle + " has been calculated.");
            }
            foreach (AbstractCompany branch in branches)
            {
                maintenanceCost += branch.CalculateMaintenanceCost();
            }
            return maintenanceCost;
        }

        public void AddBranch(AbstractCompany branch)
        {
            branches.Add(branch);
        }
    }
}