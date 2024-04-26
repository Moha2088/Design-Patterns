namespace Observer.Interface;

public interface IObserver
{
    void Update(ISubject subject);
}