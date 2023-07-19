namespace SingleResponsibilityPrinciple.Models.ExampleTwo.GoodPractice;

public class ProductRepository:IProductRepository
{
    public ProductRepository()
    {
        Connect();
    }
    public void Connect()
    {
        //Database Connection
    }

    public void Add<T>(T dbObject)
    {
        //Database Add
    }
}
