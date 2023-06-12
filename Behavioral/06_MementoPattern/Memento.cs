namespace _06_MementoPattern
{
    public class Memento
    {
        public string State { get; }
        public Memento(string state)
        {
            State = state;
        }
        public string GetState() { return State; }
    }

    public class Originator
    {
        private string _state;
        public void SetState(string state)
        {
            _state = state;
            Console.WriteLine($"Current State:{_state}");
        }
        public Memento SaveState()
        {
            return new Memento(_state);
        }
        public void RestoreState(Memento memento)
        {
            _state = memento.GetState();
            Console.WriteLine("Latest state rolled back:" + _state);
        }
    }

    public class CareTaker
    {
        private Memento _memento;
        public void Save(Originator originator)
        {
            _memento = originator.SaveState();
        }
        public void RollBackState(Originator originator)
        {
            originator.RestoreState(_memento);
        }
    }

}
