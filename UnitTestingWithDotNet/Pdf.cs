namespace UnitTestingWithDotNet;

public class Pdf : IDocumentType
{
    public string GetText(string fileName) => $"I'm a PDF document: {fileName}";
}
