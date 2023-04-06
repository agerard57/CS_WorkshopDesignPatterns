namespace Patterns.Adapter
{
    internal class PdfComponent
    {
        private string content = "Here's some PDF";
        private string output = "";

        public void SetContent(string content)
        {
            this.content = content;
        }

        public void PrepareDisplay()
        {
            this.output = "<pdf>" + this.content + "</pdf>";
        }

        public static void Refresh()
        {
            Console.WriteLine("<p>Refreshing...</p>");
        }

        public string EndDisplay()
        {
            return this.output;
        }

        public void SentToPrint()
        {
            Console.WriteLine(output);
        }
    }
}