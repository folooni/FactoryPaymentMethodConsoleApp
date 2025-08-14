using static FactoryPaymentMethodConsole.Enums.EnumList;

namespace FactoryPaymentMethodConsole;

public class PaymentFactory
{
    public static IPayment Create(PaymentMethod paymentMethod)
    {
        switch (paymentMethod)
        {
            case PaymentMethod.CreditCard:
                return new CreditCardPayment();
            case PaymentMethod.Paypal:
                return new PaypalPayment();
            case PaymentMethod.Googlepay:
                return new GooglePayPayment();
            default:
                throw new NotSupportedException($"{paymentMethod} is not currently supported as a payment method.");
        }
    }
}
