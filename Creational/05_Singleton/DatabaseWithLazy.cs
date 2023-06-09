namespace _05_Singleton
{
    public class Database
    {
        private static readonly Lazy<Database> _database = new Lazy<Database>(() => new Database());

        private Database()
        {

        }

        public static Database GetInstance()
        {
            return _database.Value;
        }


    }
}




