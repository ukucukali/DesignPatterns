using DependencyInversionPrinciple.Models.ExampleTwo.BadPractice.LowLevelClasses;

namespace DependencyInversionPrinciple.Models.ExampleTwo.BadPractice.HighLevelClasses;

public class CheckoutService
{
    private ShoppingCart _cart;
    private PaymentProcessor _paymentProcessor;

    // high level classes depends on low level concrete classes.
    // it causes tight coupling between low and high level classes.
    // it makes difficult to maintain low level classes without maintain high level class

    public CheckoutService()
    {
        _cart = new ShoppingCart();
        _paymentProcessor = new PaymentProcessor();
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