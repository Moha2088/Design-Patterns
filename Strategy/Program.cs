using Strategy.Impl;

namespace Strategy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press 1 to use add, 2 for sub, 3 for mul and 4 for div");
        int operation = int.Parse(Console.ReadLine());

        switch (operation)
        {
            case 1:
                var addContext = new OperationContext();
                addContext.SetOperation(new AddOperation());
                addContext.DoOperation();
                break;

            case 2:
                var subContext = new OperationContext();
                subContext.SetOperation(new SubOperation());
                subContext.DoOperation();
                break;

            case 3:
                var mulContext = new OperationContext();
                mulContext.SetOperation(new MulOperation());
                mulContext.DoOperation();
                break;

            case 4:
                var divContext = new OperationContext();
                divContext.SetOperation(new DivOperation());
                divContext.DoOperation();
                break;
        }
    }
}