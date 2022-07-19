using System;

namespace ConsoleApp7
{
    public class SqlLogger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine($"log message \"{msg}\" in sql");
        }
    }
}
