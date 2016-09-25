using System;
using Business.Interfaces;

namespace Business
{
    public class ServiceA : IService
    {
        #region IService Members

        public void Do(Order order)
        {
            Console.WriteLine(@"Blah, order is ok");
        }

        #endregion
    }
}