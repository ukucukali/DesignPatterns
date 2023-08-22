using InterfaceSegregationPrinciple.ExampleTwo.GoodPractice.Interface;

namespace InterfaceSegregationPrinciple.ExampleTwo.GoodPractice;

public class Printer: IPrinter
{
    // for this class only IPrinter interfaces implemented because this machine only can  
    // do printing 
    
    public void Print(string document) => Console.WriteLine($"Printing: {document}");
    
}