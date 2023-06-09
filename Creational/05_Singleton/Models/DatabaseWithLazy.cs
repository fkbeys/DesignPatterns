namespace _05_Singleton.Models
{
    public class Database
    {
        private static readonly Lazy<Database> _instance = new Lazy<Database>(() =>
        {
            Console.WriteLine("Lazy singleton creator, created an instance...");
            return new Database();
        });

        private Database()
        {
        }

        public static Database Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}




