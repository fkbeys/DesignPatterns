namespace _07_ProxyPattern
{
    public interface ISubject
    {
        void Request();

    }

    public class Subject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("Subject requested...");
        }
    }

    public class ProxyClass : ISubject
    {
        private Subject subject;

        public ProxyClass(Subject subject)
        {
            this.subject = subject;
        }
        public void Request()
        {
            if (subject == null)
            {
                Console.WriteLine("subject is null,we need to create an instance");
                subject = new Subject();
            }
            Console.WriteLine("Proxy request method worked...");
            subject.Request();
        }
    }


}
