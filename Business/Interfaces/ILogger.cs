using ServiceLocator.Interfaces;

namespace Business.Interfaces
{
    public interface ILogger : ILocator
    {
        void Log();
    }
}