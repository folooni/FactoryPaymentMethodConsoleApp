namespace FactoryPaymentMethodConsole;

public class CreditCardPayment : IPayment
{
    public void pay(double amount)
    {
        Console.WriteLine($"Amount of ${amount} was paid by a credit card.");
    }
}
