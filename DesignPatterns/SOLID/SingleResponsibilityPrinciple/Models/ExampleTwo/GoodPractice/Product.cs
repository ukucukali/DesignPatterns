using SOLID.SingleResponsibilityPrinciple.Models.ExampleTwo.GoodPractice;

namespace SingleResponsibilityPrinciple.Models.ExampleTwo.GoodPractice;

public class Product
{
    private readonly IProductRepository _productRepository;
    private readonly IEmailService _emailService;

    public Product(IProductRepository productRepository, IEmailService emailService)
    {
        _productRepository = productRepository;
        _emailService = emailService;
    }
    
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal CalculateTotalPrice()
    {
        return Price * Quantity;
    }

    public void SaveProduct(Product product)
    {
        if (product == null)
        throw new NullReferenceException();
        
        // divide workflows between separate classes
        _productRepository.Add(product);
        _emailService.Send();
    }
}