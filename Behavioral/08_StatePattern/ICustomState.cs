namespace _08_StatePattern
{
    public interface ICustomState
    {
        void Handle(CustomContext customContext);
    }

    public class CustomContext
    {
        private ICustomState _state;
        public CustomContext(ICustomState _state)
        {
            _state = _state;
        }
        public ICustomState state
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Console.WriteLine($"state changed:{_state.GetType().Name}");
            }
        }
    }

    public class ScreenA : ICustomState
    {
        public void Handle(CustomContext customContext)
        {
            Console.WriteLine("The image is Created on Screen A:");
            customContext.state = new ScreenB();
            Console.WriteLine("The image Transferred to B:");
        }
    }
    public class ScreenB : ICustomState
    {
        public void Handle(CustomContext customContext)
        {
            Console.WriteLine("The image is Created on Screen B:");
            customContext.state = new ScreenA();
            Console.WriteLine("The image Transferred to A:");
        }
    }

}
