namespace UnitTestingWithDotNet;

public class Word : IDocumentType
{
    public string GetText(string fileName) => $"I'm a Word document: {fileName}";
}
