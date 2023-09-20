using AbstractFactory.ExampleOne.Solution.Components.Themes;
using AbstractFactory.ExampleOne.Solution.Interfaces;

namespace AbstractFactory.ExampleOne.Solution.AbstractFactoryMethods;

public class LightThemeFactory : IThemeFactory
{
    public ITheme CreateTheme()
    {
        Console.WriteLine("Light Theme Created");
        return new LightTheme();
    }
}