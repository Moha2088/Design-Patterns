using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Interface;
public interface IPayment
{
    void Pay(double amountToPay);
}
