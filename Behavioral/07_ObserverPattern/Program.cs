namespace _07_ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Observable observable = new Observable();
            observable.Register(new MobilePhone("Samsung"));
            observable.Register(new MobilePhone("Xiaomi"));
            observable.Register(new MobilePhone("Apple"));

            observable.Notify();

            Console.ReadLine();
        }
    }
}