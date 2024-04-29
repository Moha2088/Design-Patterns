using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy;

public class OperationContext
{
    private IOperation _operation;


    public OperationContext()
    {
    }

    public OperationContext(IOperation operation)
    {
        _operation = operation;
    }

    public void SetOperation(IOperation operation)
    {
        _operation = operation;
    }

    public void DoOperation()
    { 
        idPrompt:
        try
        {
            Console.WriteLine("Enter the first number:");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int input2 = int.Parse(Console.ReadLine());

            var result = _operation.Calculate(input1, input2);
            
            Console.WriteLine($"The result is: {result}");
            Console.WriteLine();
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e);
            goto idPrompt;
        }
    }
}