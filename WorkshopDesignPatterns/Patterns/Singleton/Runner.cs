namespace Patterns.Singleton
{
    public class Runner
    {
        public static void Execute()
        {
            SingletonDocumentBundle documentBundle = SingletonDocumentBundle.GetInstance();

            // Add
            Console.WriteLine("Adding documents and get all...");
            documentBundle.Add("Document 1");
            documentBundle.Add("Document 2");
            documentBundle.Add("Document 3");

            Console.WriteLine("Current documents in the bundle:");
            foreach (var document in documentBundle.GetBundle())
            {
                Console.WriteLine(document);
            }
            Console.WriteLine();

            // Remove
            Console.WriteLine("Removing document and get all...");
            documentBundle.Remove("Document 2");

            Console.WriteLine("Current documents in the bundle:");
            foreach (var document in documentBundle.GetBundle())
            {
                Console.WriteLine(document);
            }
        }
    }
}