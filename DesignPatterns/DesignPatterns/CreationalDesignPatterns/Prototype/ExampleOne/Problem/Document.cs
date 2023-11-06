namespace Prototype.ExampleOne.Problem;

public class Document
{
    public string Title { get; set; }

    public string Content { get; set; }

    public string Formatting { get; set; }

    public Document(string title, string content, string formatting)
    {
        Title = title;
        Content = content;
        Formatting = formatting;
    }

    public Document Clone() => new(Title, Content, Formatting);

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Content: {Content}");
        Console.WriteLine($"Formatting: {Formatting}");
    }
}