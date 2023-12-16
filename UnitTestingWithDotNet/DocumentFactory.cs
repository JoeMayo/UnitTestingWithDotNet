namespace UnitTestingWithDotNet;

public class DocumentFactory
{
    public IDocumentType Create(string fileName)
    {
        ArgumentNullException.ThrowIfNull(fileName);

        string fileExtension = Path.GetExtension(fileName);

        return fileExtension switch
        {
            ".doc" or ".docx" => new Word(),
            ".pdf" => new Pdf(),
            _ => new Unknown()
        };
        //if (fileExtension == ".docx" || fileExtension == ".doc")
        //    return new Word();
        //else if (fileExtension == ".pdf")
        //    return new Pdf();

        //return new Unknown();
    }
}
