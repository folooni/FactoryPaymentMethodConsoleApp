namespace FactoryPaymentMethodConsole;

public class GooglePayPayment : IPayment
{
    public void pay(double amount)
    {
        Console.WriteLine($"Amount of ${amount} was paid by Google Pay.");
    }
}
