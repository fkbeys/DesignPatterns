namespace _06_MementoPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new();
            CareTaker careTaker = new();

            originator.SetState("Insert into 2 tables at the same time in one transaction");
            careTaker.Save(originator);

            originator.SetState("Cancel the transaction due to an error");

            careTaker.RollBackState(originator);

            Console.ReadLine();
        }
    }
}