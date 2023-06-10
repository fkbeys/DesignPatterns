namespace _02_CommandPattern
{
    public interface ICommand
    {
        public void execute();
    }

    public class FirstClass : ICommand
    {
        public void execute()
        {
            Console.WriteLine("Hello first class");
        }
    }
    public class EconomyClass : ICommand
    {
        public void execute()
        {
            Console.WriteLine("Hello to the economy class");
        }
    }

    public class CustomInvoker : ICommand
    {
        private ICommand _command { get; set; }
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void execute()
        {
            _command.execute();
        }
    }

}
