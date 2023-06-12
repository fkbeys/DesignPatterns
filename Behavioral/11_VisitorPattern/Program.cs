namespace _11_VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConcreteVisiter concreteVisiter = new ConcreteVisiter();
            //concreteVisiter.Visit(new ConcreteA());
            //concreteVisiter.Visit(new ConcreteB());

            var elemnets = new IElement[] { new ConcreteA(), new ConcreteB() };
            var vizitor = new ConcreteVisiter();

            foreach (var element in elemnets)
            {
                element.Accept(vizitor);
            }

            Console.ReadLine();
        }
    }
}