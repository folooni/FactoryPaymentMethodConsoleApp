namespace FactoryPaymentMethodConsole;

public class PaypalPayment : IPayment
{
    public void pay(double amount)
    {
        Console.WriteLine($"Amount of ${amount} was paid by Paypal.");
    }
}
