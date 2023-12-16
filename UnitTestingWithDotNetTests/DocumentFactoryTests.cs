using UnitTestingWithDotNet;

namespace UnitTestingWithDotNetTests;

public class DocumentFactoryTests
{
    DocumentFactory docFact = new();

    [Fact]
    public void Create_WithWordDoc_ReturnsWordDocumentType()
    {
        IDocumentType docType = docFact.Create("MyWordDoc.docx");

        Assert.NotNull(docType);
        Assert.IsAssignableFrom<Word>(docType);
    }

    [Fact]
    public void Create_WithUnknownDoc_ReturnsUnknownDocumentType()
    {
        IDocumentType docType = docFact.Create("MyWordDoc.unk");

        Assert.NotNull(docType);
        Assert.IsAssignableFrom<Unknown>(docType);
    }

    [Fact]
    public void Create_WithPdfDoc_ReturnsPdfDocumentType()
    {
        IDocumentType docType = docFact.Create("MyWordDoc.pdf");

        Assert.NotNull(docType);
        Assert.IsAssignableFrom<Pdf>(docType);
    }

    [Fact]
    public void Create_WithNullFilename_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => docFact.Create(null));
    }
}