namespace Factory.ExampleOne.Solution.Interfaces;

public interface IPaymentProcessorFactory
{
    PaymentMethod CreatePaymentMethod();
}