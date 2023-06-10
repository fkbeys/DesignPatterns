using System.Collections;

namespace _03_IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StudentCollection studentCollection = new StudentCollection();
            Student student = new Student("Mark", "Twain");
            studentCollection.AddStudent(student);
            IEnumerator enumerator = studentCollection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Student stnd = (Student)enumerator.Current;
                Console.WriteLine(stnd.name);
            }



            Console.ReadKey();
        }
    }
}