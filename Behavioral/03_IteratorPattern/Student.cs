using System.Collections;

namespace _03_IteratorPattern
{
    public class Student
    {
        public string name { get; set; }
        public string surname { get; set; }

        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }

    public class StudentCollection : IEnumerable
    {
        private ArrayList _students = new();

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public IEnumerator GetEnumerator()
        {
            return _students.GetEnumerator();
        }



    }
}
