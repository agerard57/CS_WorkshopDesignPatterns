namespace Patterns.Adapter
{
    internal interface IDocument
    {
        void SetContent(string content);

        string Draw();

        void SentToPrint();
    }
}