namespace _03_CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("started");
            //MenuItem pizza = new MenuItem("Pizza", 10);
            //MenuItem hamburger = new MenuItem("Hamburger", 5);
            //MenuItem rice = new MenuItem("Rice", 3);

            //Menu menu = new Menu("Dinner Menu");
            //menu.Add(pizza);
            //menu.Add(hamburger);
            //menu.Add(rice);
            //menu.Print();

            Empolyee empolyee1 = new Empolyee("John", "Construction-Worker");
            Empolyee empolyee2 = new Empolyee("Mert", "Construction-Nurse");
            Empolyee empolyee3 = new Empolyee("Fredy", "Construction-Doctor");
            Empolyee empolyee4 = new Empolyee("Micky", "Construction-Worker");

            Chef ConstructionChef = new Chef("David");
            ConstructionChef.Add(empolyee1);
            ConstructionChef.Add(empolyee2);
            ConstructionChef.Add(empolyee3);
            ConstructionChef.Add(empolyee4);

            Manager regionalManager = new Manager("Frank");
            regionalManager.Add(ConstructionChef);
            regionalManager.Print();


            Console.ReadLine();
        }
    }
}