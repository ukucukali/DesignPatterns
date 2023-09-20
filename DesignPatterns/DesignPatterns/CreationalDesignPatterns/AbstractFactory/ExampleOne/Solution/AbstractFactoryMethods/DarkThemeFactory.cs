using AbstractFactory.ExampleOne.Solution.Components.Themes;
using AbstractFactory.ExampleOne.Solution.Interfaces;

namespace AbstractFactory.ExampleOne.Solution.AbstractFactoryMethods;

public class DarkThemeFactory : IThemeFactory
{
    public ITheme CreateTheme()
    {
        Console.WriteLine("Dark Theme Created");
        return new DarkTheme();
    }
}