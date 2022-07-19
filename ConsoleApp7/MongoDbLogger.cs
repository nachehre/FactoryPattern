using System;

namespace ConsoleApp7
{
    public class MongoDbLogger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine($"log message \"{msg}\" in mongodb");
        }
    }
}
