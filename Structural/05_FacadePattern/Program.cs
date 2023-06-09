namespace _05_FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubsystemA subsystemA = new();
            SubsystemB subsystemB = new();
            SubsystemManagement subsystemManagement = new(subsystemA, subsystemB);
            Console.WriteLine(subsystemManagement.Work1());
            Console.WriteLine(subsystemManagement.Work2());


            Console.ReadLine();
        }
    }
}