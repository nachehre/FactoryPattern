namespace ConsoleApp1
{
    public interface ISmsSenderFactory
    {
        ISmsSender CreateSender(string serviceName);
    }
}
