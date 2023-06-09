namespace _06_SingletonWithDependencyInjection.Db
{
    public interface IAppDatabase
    {
        AppDatabase Instance { get; }
    }

    public class AppDatabase : IAppDatabase
    {
        private static Lazy<AppDatabase> _instance = new Lazy<AppDatabase>(() =>
        {
            Console.WriteLine($"Database instance created...{DateTime.Now}");
            return new AppDatabase();
        });

        // Yapıcı (constructor) private oldu
        private AppDatabase()
        {
        }

        public static AppDatabase Create()
        {
            return _instance.Value;
        }

        public AppDatabase Instance
        {
            get { return _instance.Value; }
        }
    }

}
