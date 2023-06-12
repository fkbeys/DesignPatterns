namespace _07_ObserverPattern
{
    public interface IObserver
    {
        public void Update(string message);
    }

    public interface IObservable
    {
        public void Register(IObserver observer);
        public void UnRegister(IObserver observer);
        public void Notify();
    }
    public class Observable : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _message;
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_message);
            }
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void SendMessage(string message)
        {
            _message = message;
            Notify();
        }
    }

    public class MobilePhone : IObserver
    {
        private string Model { get; }
        public MobilePhone(string model)
        {
            Model = model;
        }


        public void Update(string message)
        {
            Console.WriteLine(Model+" message received:" + message);
        }
    }

}
