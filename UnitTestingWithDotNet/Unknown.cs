namespace UnitTestingWithDotNet;

public class Unknown : IDocumentType
{
    public string GetText(string fileName) => $"I'm an Unknown document: {fileName}";
}
