using DependencyInversionPrinciple.ExampleTwo.GoodPractice.LowLevelClasses;
using DependencyInversionPrinciple.ExampleTwo.GoodPractice.LowLevelClasses.Interfaces;

namespace DependencyInversionPrinciple.ExampleTwo.GoodPractice.HighLevelClasses;

public class CheckoutService
{
    private ShoppingCart _cart;
    private IPaymentProcessor _paymentProcessor;

    // ShoppingCart and product classes complement each other
    // but CheckoutService high level classes depended on low level Payment Processor concrete class.
    // it causes tight coupling between low and high level classes.
    // so Payment Processor class loose coupled and it made code more maintainable. 

    public CheckoutService(IPaymentProcessor paymentProcessor)
    {
        _cart = new ShoppingCart();
        _paymentProcessor = paymentProcessor;
    }

    public void AddToCart(Product product)
    {
        _cart.AddToCart(product);
    }

    public void Checkout()
    {
        decimal totalAmount = _cart.GetCartItems().Sum(item => item.Price);

        _paymentProcessor.ProcessPayment(totalAmount);

        Console.WriteLine("Thank you for your purchase!");
    }
}