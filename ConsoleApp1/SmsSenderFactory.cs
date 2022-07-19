using System;

namespace ConsoleApp1
{
    public class SmsSenderFactory : ISmsSenderFactory
    {
        public ISmsSender CreateSender(string serviceName)
        {
            switch (serviceName)
            {
                case "nasim":
                    return new NasimSmsService();
                case "chehreh":
                    return new ChehrehSmsService();
                case "iria":
                    return new IriaSmsService();
            }

            throw new Exception("sms service not found");
        }
    }
}
