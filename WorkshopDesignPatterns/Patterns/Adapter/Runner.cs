namespace Patterns.Adapter
{
    public class Runner
    {
        public static void Execute()
        {
            {
                IDocument htmlDocument = new HtmlDocument();

                htmlDocument.SetContent("Here's an HTML doc");
                Console.WriteLine(htmlDocument.Draw());

                PdfComponent pdfComponent = new();
                IDocument pdfDocument = new PdfDocument(pdfComponent);

                pdfDocument.SetContent("Here's a PDF doc");
                Console.WriteLine(pdfDocument.Draw());
            }
        }
    }
}