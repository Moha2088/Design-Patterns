namespace RegularSingleton;

internal class Program
{
    static void Main(string[] args)
    {
        Singleton firstInstance = Singleton.GetInstance();
        Singleton secondInstance = Singleton.GetInstance();

        if(firstInstance == secondInstance) 
        {
            Console.WriteLine("Singleton works! Both instances are identical");
        }

        else
        {
            Console.WriteLine("Both instances are unique :(");
        }
    }
}