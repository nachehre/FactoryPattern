using Microsoft.Extensions.Logging;
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                //builder.AddConsole();
                builder.AddFile(o => o.RootPath = AppContext.BaseDirectory);
            });

            ILogger logger = loggerFactory.CreateLogger<Program>();

            logger.LogInformation("Info Log");
            logger.LogWarning("Warning Log");
            logger.LogError("Error Log");
            logger.LogCritical("Critical Log");

            Console.ReadLine();
        }
    }
}
