using Business.Interfaces;

namespace Business
{
    public class Manager
    {
        private readonly ServiceLocator.ServiceLocator _serviceLocator;

        public Manager()
        {
            _serviceLocator = ServiceLocator.ServiceLocator.Instance;
        }

        public void Process(Order order)
        {
            var logger = _serviceLocator.Get<ILogger>();
            var service = _serviceLocator.Get<IService>();

            service.Do(order);
            logger.Log();
        }
    }
}