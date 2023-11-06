using Prototype.ExampleOne.Solution.Interfaces;

namespace Prototype.ExampleOne.Solution;

public class Document : IDocumentPrototype
{
    public string Title { get; private set; }

    public string Content { get; private set; }

    public string Formatting { get; private set; }

    public Document(string title, string content, string formatting)
    {
        Title = title;
        Content = content;
        Formatting = formatting;
    }

    public void SetTitle(string title)
    {
        Title = title;
    }

    public void SetContent(string content)
    {
        Content = content;
    }

    public void SetFormatting(string formatting)
    {
        Formatting = formatting;
    }

    public IDocumentPrototype Clone() => (IDocumentPrototype)MemberwiseClone();

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Content: {Content}");
        Console.WriteLine($"Formatting: {Formatting}");
    }
}