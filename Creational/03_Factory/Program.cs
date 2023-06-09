using _03_Factory.Models;

namespace _03_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            WebFactory factory = new BlogFactory();
            
            factory.CreateWebPage();

             
            Console.ReadLine(); 
        }
    }
}