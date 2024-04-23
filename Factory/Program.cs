using Factory.Enums;
using Factory.Factory;
using Factory.Interface;
using System;

namespace Factory;

internal class Program 
{
    static void Main(string[] args)
    {
        IPayment payment = PaymentFactory.create(PaymentMethod.MobilePay);
        payment.Pay(100.00);   
    }
}