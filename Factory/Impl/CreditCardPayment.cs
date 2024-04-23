using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Impl;
public class CreditCardPayment : IPayment
{
    public void Pay(double amountToPay)
    {
        Console.WriteLine($"Successfully paid {amountToPay} with CreditCard!");
    }
}
