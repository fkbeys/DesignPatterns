namespace _03_CompositePattern
{
    public abstract class Staff
    {
        public abstract void Print();
    }
    public class Empolyee : Staff
    {
        private readonly string name;
        private readonly string profession;

        public Empolyee(string name, string profession)
        {
            this.name = name;
            this.profession = profession;
        }
        public override void Print()
        {
            Console.WriteLine($"Employee Name:{name}, Proffession:{profession}");
        }
    }
    public class Chef : Staff
    {
        private readonly List<Empolyee> empolyees = new List<Empolyee>();
        private readonly string name;

        public Chef(string name)
        {
            this.name = name;
            Console.WriteLine($"Chef Name:{name}");
        }
        public override void Print()
        {
            foreach (var item in empolyees)
            {
                item.Print();
            }
        }
        public void Add(Empolyee empolyee)
        {
            empolyees.Add(empolyee);
        }
    }
    public class Manager : Staff
    {
        private readonly List<Chef> empolyees = new List<Chef>();
        private readonly string name;

        public Manager(string name)
        {
            this.name = name;
            Console.WriteLine($"Manager Name:{name}");
        }

        public override void Print()
        {
            foreach (var item in empolyees)
            {
                item.Print();
            }
        }
        public void Add(Chef chef)
        {
            empolyees.Add(chef);
        }
    }


}
