namespace OpenClosedPrincible.Models.GoodPractice;

public class CashPayment : Payment
{
    public override void Pay(Money money)
    {
        base.Pay(money);
        
        // Also additional operation for Cash Payment can be written here
    }
}