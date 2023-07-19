using InterfaceSegregationPrinciple.Models.ExampleTwo.GoodPractice.Interface;

namespace InterfaceSegregationPrinciple.Models.ExampleTwo.GoodPractice;

public class Printer: IPrinter
{
    // for this class only IPrinter interfaces implemented because this machine only can  
    // do printing 
    
    public void Print(string document) => Console.WriteLine($"Printing: {document}");
    
}