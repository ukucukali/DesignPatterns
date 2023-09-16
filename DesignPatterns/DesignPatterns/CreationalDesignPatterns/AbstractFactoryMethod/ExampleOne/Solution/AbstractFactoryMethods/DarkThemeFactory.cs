using AbstractFactoryMethod.ExampleOne.Solution.Components.Themes;
using AbstractFactoryMethod.ExampleOne.Solution.Interfaces;

namespace AbstractFactoryMethod.ExampleOne.Solution.AbstractFactoryMethods;

public class DarkThemeFactory : IThemeFactory
{
    public ITheme CreateTheme()
    {
        Console.WriteLine("Dark Theme Created");
        return new DarkTheme();
    }
}