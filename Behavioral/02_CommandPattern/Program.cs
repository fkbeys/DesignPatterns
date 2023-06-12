namespace _02_CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomInvoker customInvoker = new CustomInvoker();
            customInvoker.SetCommand(new FirstClass());

            customInvoker.execute();

            Console.ReadLine();
        }
    }
}