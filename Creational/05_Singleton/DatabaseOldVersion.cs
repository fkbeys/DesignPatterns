namespace _05_Singleton
{
    public class DatabaseOldVersion
    {
        private static DatabaseOldVersion _database;
        private static readonly object _lock = new object();

        private DatabaseOldVersion()
        {

        }

        public static DatabaseOldVersion database
        {
            get
            {
                lock (_lock)
                {
                    if (_database == null)
                    {
                        Console.WriteLine("db old singleton version created.");
                        _database = new DatabaseOldVersion { };
                    }
                    return _database;
                }
            }
        }
    }
}




