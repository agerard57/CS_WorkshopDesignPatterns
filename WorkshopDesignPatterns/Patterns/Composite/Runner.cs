namespace Patterns.Composite
{
    internal class Runner
    {
        public static void Execute()
        {
            ParentCompany parentCompany = new ParentCompany();

            SubsidiaryCompany subsidiaryCompany1 = new SubsidiaryCompany();
            SubsidiaryCompany subsidiaryCompany2 = new SubsidiaryCompany();
            SubsidiaryCompany subsidiaryCompany3 = new SubsidiaryCompany();

            parentCompany.AddBranch(subsidiaryCompany1);
            parentCompany.AddBranch(subsidiaryCompany2);
            parentCompany.AddBranch(subsidiaryCompany3);

            int maintenanceCost = parentCompany.CalculateMaintenanceCost();

            Console.WriteLine("Total maintenance cost for the company and its subsidiaries: " + maintenanceCost);
        }
    }
}