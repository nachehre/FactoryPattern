namespace ConsoleApp7
{
    public interface ILoggerFactyory
    {
        ILogger Create(string loggerName);
    }

    public class LoggerFactyory : ILoggerFactyory
    {
        public ILogger Create(string loggerName)
        {
            switch (loggerName)
            {
                case "sql":
                    return new SqlLogger();

                case "file":
                    return new FileLogger();

                case "mongo":
                    return new MongoDbLogger();
                case "console":
                    return new ConsoleLogger();
                default:
                    return new ConsoleLogger();
            }
        }
    }
}
