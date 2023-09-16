using AbstractFactoryMethod.ExampleOne.Solution.AbstractFactoryMethods;
using AbstractFactoryMethod.ExampleOne.Solution.Components.Buttons;
using AbstractFactoryMethod.ExampleOne.Solution.Components.CheckBoxes;
using AbstractFactoryMethod.ExampleOne.Solution.Interfaces;

/*
  STRUCTURE
 * Create main abstract/interface  for a set of distinct but related products which make up a product family.
 * Create concrete methods related to main class are various implementations of abstract products,
   grouped by variants. Each abstract product must be implemented in all given variants.
 * Create main factories ( MainProductName + Factory) interface which is common to all objects that can be produced by the creator and its subclasses.
 * Create Factory classes for each subclasses (subclassName + Factory ), apply necessary controls etc. and return new instances of them.
 * Create abstract factory( AbstractFactoryName + Factory) interface which declares a set of methods for creating each of the abstract products.
 * Create new instance of needed subclasses factory class and it will be treated as main class
 */


#region Example One - Themes

#region Problem

/*
    Down sides
 *  Lack of abstraction : Code doesn't provide clear separation between components, so  it doesn't encapsulate the theme-specific logic.
 *  Reduced Flexibility : When there is a need to add different theme or maintain existing ones in the application there is need to modify core of the code
 *  Maintenance Difficulties : As the application grows and themes gets more complex, maintaining and modifying theme-related code can become challenging.
 *  Hard to chance/swap : Swapping out the implementation of a UI component for a different theme would require changes throughout the codebase.
 */ 

IButton lightButton = new LightButton();
ICheckbox lightCheckbox = new LightCheckbox();

lightButton.Render();
lightCheckbox.Render();

Console.WriteLine("------------------");

IButton darkButton = new DarkButton();
ICheckbox darkCheckbox = new DarkCheckbox();

darkButton.Render();
darkCheckbox.Render();

#endregion

Console.WriteLine("=============================");

#region Solution

IThemeFactory themeFactory1 = new LightThemeFactory();
ITheme theme1 = themeFactory1.CreateTheme();
IButton button1 = theme1.CreateButton();
ICheckbox checkbox1= theme1.CreateCheckbox();
button1.Render();
checkbox1.Render();

Console.WriteLine("------------------");

IThemeFactory themeFactory2 = new DarkThemeFactory();
ITheme theme2 = themeFactory2.CreateTheme();
IButton button2 = theme2.CreateButton();
ICheckbox checkbox2= theme2.CreateCheckbox();
button2.Render();
checkbox2.Render();

#endregion

#endregion