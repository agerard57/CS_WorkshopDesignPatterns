namespace Patterns.Singleton

{
    internal class SingletonDocumentBundle
    {
        private SingletonDocumentBundle()
        { }

        private static SingletonDocumentBundle? instance;
        private readonly List<string> DocumentBundle = new();

        public static SingletonDocumentBundle GetInstance()
        {
            instance ??= new();
            return instance;
        }

        public void Add(string doc)
        {
            DocumentBundle.Add(doc);
        }

        public void Remove(string doc)
        {
            DocumentBundle.Remove(doc);
        }

        public List<string> GetBundle()
        {
            return DocumentBundle;
        }
    }
}