namespace InterfaceSegregationPrinciple.ExampleOne.GoodPractice;

public abstract class BaseEmployee
{
    // An abstract class or IBaseEmployee interface can serve as the foundation for this class.
    // However, an abstract class has been chosen to avoid repeating properties in each implemented class and prevent redundancy.
    
    public string Id { get; set; }
    
    public string Name { get; set; }
    
    public string Email { get; set; }
}