namespace _05_Singleton
{
    public class CustomLogger
    {
        private static Lazy<CustomLogger> _logger = new Lazy<CustomLogger>(() => new CustomLogger { });

        private CustomLogger()
        {

        }

        public static CustomLogger Instance()
        {
            return _logger.Value;
        }



    }
}
