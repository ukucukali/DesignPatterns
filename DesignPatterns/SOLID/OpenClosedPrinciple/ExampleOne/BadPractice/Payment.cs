namespace OpenClosedPrinciple.ExampleOne.BadPractice;

public class Payment
{
    public PaymentType PaymentType { get; set; }

    public void Pay(Money money)
    {
        //When added new payment method it means this method should always be modified
        //and this violates OCP.
        
        if (PaymentType == PaymentType.Cash)
        {
            // operations when payment type is cash   
        }
        else if (PaymentType == PaymentType.CreditCard)
        {
            // operations when payment type is creditcard   
        }
        else
        {
            // operations when payment type will added next
        }
    }
}

public enum PaymentType
{
    Cash,
    CreditCard
}