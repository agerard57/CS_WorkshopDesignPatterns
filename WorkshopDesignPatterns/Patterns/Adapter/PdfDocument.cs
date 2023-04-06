namespace Patterns.Adapter
{
    internal class PdfDocument : IDocument
    {
        public PdfDocument(PdfComponent pdfComponent)
        {
            PdfComponent = pdfComponent;
        }

        private PdfComponent PdfComponent { get; } = new PdfComponent();

        public string Draw()
        {
            this.PdfComponent.PrepareDisplay();
            PdfComponent.Refresh();
            return PdfComponent.EndDisplay();
        }

        public void SentToPrint()
        {
            PdfComponent.PrepareDisplay();
            PdfComponent.SentToPrint();
        }

        public void SetContent(string content)
        {
            PdfComponent.SetContent(content);
        }
    }
}