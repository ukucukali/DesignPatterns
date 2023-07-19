namespace DependencyInversionPrinciple.Models.ExampleTwo.BadPractice.LowLevelClasses;

public class ShoppingCart
{
    private List<Product> _cartItems;

    public ShoppingCart()
    {
        _cartItems = new List<Product>();
    }

    public void AddToCart(Product product) => _cartItems.Add(product);

    public IEnumerable<Product> GetCartItems() => _cartItems;
}