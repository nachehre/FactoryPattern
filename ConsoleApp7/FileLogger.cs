using System;

namespace ConsoleApp7
{
    public class FileLogger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine($"log message \"{msg}\" in file");
        }
    }
}
