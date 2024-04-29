using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Impl;
public class DivOperation : IOperation
{
    public double Calculate(double a, double b)
    {
        return a / b;
    }
}
