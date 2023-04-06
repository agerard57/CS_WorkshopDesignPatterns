namespace Patterns.Adapter
{
    internal class HtmlDocument : IDocument
    {
        private string content;

        public HtmlDocument()
        {
            this.content = "";
        }

        protected string GetContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public string Draw()
        {
            return "<html>" + content + "</html>";
        }

        public void SentToPrint()
        {
            Console.WriteLine("Print: <html>" + content + "</html>");
        }
    }
}