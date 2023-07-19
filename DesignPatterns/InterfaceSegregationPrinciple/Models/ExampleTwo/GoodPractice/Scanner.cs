using InterfaceSegregationPrinciple.Models.ExampleTwo.GoodPractice.Interface;

namespace InterfaceSegregationPrinciple.Models.ExampleTwo.GoodPractice;

public class Scanner: IScanner
{
    // for this class only IScanner interfaces implemented because
    // this machine only can do scanning 
    
    public void Scan(string document) => Console.WriteLine($"Scanning: {document}");
}