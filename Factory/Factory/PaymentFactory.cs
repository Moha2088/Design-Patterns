using Factory.Enums;
using Factory.Impl;
using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory;
abstract class PaymentFactory
{
    public static IPayment create(PaymentMethod paymentMethod)
    {
        switch(paymentMethod) 
        {
           case PaymentMethod.MobilePay:
                return new MobilePayPayment();

            case PaymentMethod.GooglePay:
                return new GooglePayPayment();

            case PaymentMethod.CreditCard:
                return new CreditCardPayment();

            case PaymentMethod.Bitcoin:
                return new BitcoinPayment();

            default:
                throw new NotSupportedException($" {paymentMethod} is not supported!");
        }
    }

}
