namespace _07_ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ProxyClass proxyClass = new ProxyClass(null);
            //proxyClass.Request();


            var subject = new Subject();

            ProxyClass proxyClass = new ProxyClass(subject);
            proxyClass.Request();


            Console.ReadLine();
        }
    }
}