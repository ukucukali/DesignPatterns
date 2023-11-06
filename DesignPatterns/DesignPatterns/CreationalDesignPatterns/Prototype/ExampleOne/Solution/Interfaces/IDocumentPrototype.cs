namespace Prototype.ExampleOne.Solution.Interfaces;

public interface IDocumentPrototype
{
    void SetTitle(string title);

    void SetContent(string content);

    void SetFormatting(string formatting);

    IDocumentPrototype Clone();

    void Display();
}