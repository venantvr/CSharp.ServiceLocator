using ServiceLocator.Interfaces;

namespace Business.Interfaces
{
    public interface IService : ILocator
    {
        void Do(Order order);
    }
}