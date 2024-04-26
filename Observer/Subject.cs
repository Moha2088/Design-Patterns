using Observer.Interface;

namespace Observer;

public class Subject : ISubject // Contains the state and notifies observers of changes to the state
{
    public int State { get; set; } = -0;

    private List<IObserver> _observers = new List<IObserver>();
    
    public void Attach(IObserver observer)
    {
        Console.WriteLine("Subject: Attached an observer!");
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        Console.WriteLine("Subject: Detached an observer!");
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public async void BusinessLogic()
    {
        Console.WriteLine("\nSubject: I am doing something important!");
        State = new Random().Next(10);
        Thread.Sleep(15);
        Console.WriteLine($"My state just changed to: {State}");
        Notify();
    }
}