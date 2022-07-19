using Microsoft.Extensions.Configuration;
using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            var loggerName = config.GetSection("LoggerName").Value;

            var loggerFactory = new LoggerFactyory();
            var logger = loggerFactory.Create(loggerName);

            

            logger.Log("info 110");

            Console.Read();
        }
    }
}
