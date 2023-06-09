namespace _03_CompositePattern
{
    public abstract class MenuComponent
    {
        public abstract void Print();
        public virtual void Add(MenuComponent menuComponent)
        {
            Console.WriteLine("Add");
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            Console.WriteLine("Remove");
        }
    }
    public class MenuItem : MenuComponent
    {
        private readonly string name;
        private readonly decimal price;

        public override void Print()
        {
            Console.WriteLine($"Print  Name:{name},Prica:{price}");
        }

        public MenuItem(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public override void Add(MenuComponent menuComponent)
        {
            Console.WriteLine("item add");
            base.Add(menuComponent);
        }
        public override void Remove(MenuComponent menuComponent)
        {
            Console.WriteLine("item remove");
            base.Remove(menuComponent);
        }
    }

    public class Menu : MenuComponent
    {

        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private readonly string name;

        public Menu(string name)
        {
            this.name = name;
        }

        public override void Print()
        {
            //Console.WriteLine($"Name:{name}");
            foreach (var item in _menuComponents)
            {
                item.Print();
            }
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
            // base.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
            //base.Remove(menuComponent);
        }

    }


}
