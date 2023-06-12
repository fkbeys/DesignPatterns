namespace _08_StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomState screenA = new ScreenA();
            CustomContext customContext = new CustomContext(screenA);
            //customContext.state.Handle(customContext);
            screenA.Handle(customContext);
             
        }
    }
}