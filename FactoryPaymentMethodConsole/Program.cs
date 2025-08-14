using FactoryPaymentMethodConsole;
using FactoryPaymentMethodConsole.Enums;

IPayment payment = PaymentFactory.Create(EnumList.PaymentMethod.Googlepay);
payment.pay(200000);
