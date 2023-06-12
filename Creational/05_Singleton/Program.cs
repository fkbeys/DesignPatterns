namespace _05_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fx1 = DatabaseOldVersion.database;
            var fx2 = DatabaseOldVersion.database;
            var fx3 = DatabaseOldVersion.database;
            var fx4 = DatabaseOldVersion.database;
            var fx5 = DatabaseOldVersion.database;
            var fx6 = DatabaseOldVersion.database;


            var lazy1 = Database.GetInstance;
            var lazy2 = Database.GetInstance;
            var lazy3 = Database.GetInstance;




            Console.Read();

        }
    }
}