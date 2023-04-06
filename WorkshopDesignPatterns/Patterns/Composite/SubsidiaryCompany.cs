namespace Patterns.Composite
{
    internal class SubsidiaryCompany : AbstractCompany
    {
        public override int CalculateMaintenanceCost()
        {
            int maintenanceCost = 0;
            foreach (string vehicle in vehicles)
            {
                maintenanceCost += 1;
                Console.WriteLine("Maintenance cost for " + vehicle + " has been calculated.");
            }
            return maintenanceCost;
        }
    }
}