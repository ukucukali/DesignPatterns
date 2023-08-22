using InterfaceSegregationPrinciple.ExampleTwo.GoodPractice.Interface;

namespace InterfaceSegregationPrinciple.ExampleTwo.GoodPractice;

public class Scanner: IScanner
{
    // for this class only IScanner interfaces implemented because
    // this machine only can do scanning 
    
    public void Scan(string document) => Console.WriteLine($"Scanning: {document}");
}