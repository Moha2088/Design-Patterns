namespace Observer;

internal class Program
{
    static void Main(string[] args)
    {
        var subject = new Subject();
        var observerA = new ConcreteObserverA();
        subject.Attach(observerA);
        
        var observerB = new ConcreteObserverB();
        subject.Attach(observerB);
        
        subject.BusinessLogic();
        subject.BusinessLogic();
        
        subject.Detach(observerB);
        
        subject.BusinessLogic();
        
    }
}