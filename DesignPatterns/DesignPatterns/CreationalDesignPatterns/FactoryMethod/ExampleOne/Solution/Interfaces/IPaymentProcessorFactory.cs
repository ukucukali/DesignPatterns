namespace FactoryMethod.ExampleOne.Solution.Interfaces;

public interface IPaymentProcessorFactory
{
    PaymentMethod CreatePaymentMethod();
}