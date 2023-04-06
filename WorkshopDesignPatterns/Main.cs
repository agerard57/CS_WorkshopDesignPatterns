namespace DesignPatterns
{
    public class Program
    {
        private static readonly List<(string DesignName, Action Action)> designList = new()
        {
            ("Adapter", Patterns.Adapter.Runner.Execute),
            ("Command", Patterns.Command.Runner.Execute),
            ("Composite", Patterns.Composite.Runner.Execute),
            ("Decorator", Patterns.Decorator.Runner.Execute),
            ("Flyweight", Patterns.Flyweight.Runner.Execute),
            ("Observer", Patterns.Observer.Runner.Execute),
            ("Singleton", Patterns.Singleton.Runner.Execute),
            ("State", Patterns.State.Runner.Execute),
            ("Strategy", Patterns.Strategy.Runner.Execute),
            ("Template Method", Patterns.TemplateMethod.Runner.Execute)
        };

        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Design Patterns Menu");
                Console.WriteLine("--------------------");

                for (int i = 0; i < designList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {designList[i].DesignName}");
                }

                Console.WriteLine($"{designList.Count + 1}. Run all");
                Console.WriteLine($"{designList.Count + 2}. Exit");

                Console.Write("Select an option: ");
                string input = Console.ReadLine() ?? "";

                if (int.TryParse(input, out int choice))
                {
                    if (choice >= 1 && choice <= designList.Count)
                    {
                        RunDesign(designList[choice - 1]);
                    }
                    else if (choice == designList.Count + 1)
                    {
                        RunAllDesigns();
                    }
                    else if (choice == designList.Count + 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        private static void RunDesign((string, Action) design)
        {
            Console.Clear();
            Console.WriteLine($"--- {design.Item1} ---");

            try
            {
                design.Item2.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex}");
            }

            Console.WriteLine("---------------------\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void RunAllDesigns()
        {
            foreach (var design in designList)
            {
                RunDesign(design);
            }
        }
    }
}