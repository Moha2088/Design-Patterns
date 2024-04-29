namespace Singleton;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
                 "{0}\n{1}\n\n{2}\n",
                 "If you see the same value, then singleton was reused (yay!)",
                 "If you see different values, then 2 singletons were created (booo!!)",
                 "RESULT:"
             );

        Thread t1 = new Thread(() =>
        {
            TestSingleton("Foo");
        });

        Thread t2 = new Thread(() =>
        {
            TestSingleton("Bar");
        });

        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();

    }

    public static void TestSingleton(string value)
    {
        Singleton s1 = Singleton.GetInstance(value);
        Console.WriteLine(s1.Value);
    }
}