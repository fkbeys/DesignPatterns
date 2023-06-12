namespace _11_VisitorPattern
{
    public interface IVizitor
    {
        public void Visit(ConcreteA concreteA);
        public void Visit(ConcreteB concreteB);
    }

    public interface IElement
    {
        public void Accept(IVizitor vizitor);

    }

    public class ConcreteA : IElement
    {
        public void Accept(IVizitor vizitor)
        {
            vizitor.Visit(this);
        }
        public string OperationA()
        {
            return "Operation A";
        }
    }

    public class ConcreteB : IElement
    {
        public void Accept(IVizitor vizitor)
        {
            vizitor.Visit(this);
        }
        public string OperationB()
        {
            return "Operation B";
        }
    }

    public class ConcreteVisiter : IVizitor
    {
        public void Visit(ConcreteA concreteA)
        {
            Console.WriteLine("Visitir A operation A" + concreteA.OperationA());
        }

        public void Visit(ConcreteB concreteB)
        {
            Console.WriteLine("Visitir B operation B:" + concreteB.OperationB());
        }
    }
}
