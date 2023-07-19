namespace OpenClosedPrinciple.Models.GoodPractice;

public class CreditCardPayment:Payment
{
    public override void Pay(Money money)
    {
        base.Pay(money);
        
        // Also additional operation for CreditCard Payment can be written here
    }
}