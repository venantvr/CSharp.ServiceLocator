using System;
using System.Collections.Generic;
using ServiceLocator.Interfaces;
using Tools;

namespace ServiceLocator
{
    public class ServiceLocator
    {
        private static readonly Lazy<ServiceLocator> Lazy = new Lazy<ServiceLocator>(() => new ServiceLocator());
        private readonly Dictionary<Type, Lazy<ILocator>> _services;

        private ServiceLocator()
        {
            var configuration = new Configuration();
            var factory = new DefaultFactory(configuration);
            Initialize(factory);

            _services = new Dictionary<Type, Lazy<ILocator>>();
        }

        public static ServiceLocator Instance
        {
            get { return Lazy.Value; }
        }

        private ServiceLocator Initialize(IFactory factory)
        {
            foreach (var item in factory.Items)
            {
                _services.Add(item.Key, item.Value);
            }

            return this;
        }

        public T Get<T>()
        {
            var returnObject = _services[typeof (T)].Value;
            return (T) returnObject;
        }
    }

    //public class ServiceLocator
    //{
    //    private readonly Dictionary<Type, Lazy<ILocator>> _services;

    //    public ServiceLocator(IFactory factory)
    //    {
    //        _services = new Dictionary<Type, Lazy<ILocator>>();

    //        foreach (var item in factory.Items)
    //        {
    //            _services.Add(item.Key, item.Value);
    //        }
    //    }

    //    public T Get<T>()
    //    {
    //        ILocator returnObject = _services[typeof (T)].Value;
    //        return (T) returnObject;
    //    }
    //}

    //public static class ServiceLocator
    //{
    //    private static readonly Dictionary<Type, Lazy<ILocator>> Services;

    //    static ServiceLocator()
    //    {
    //        Services = new Dictionary<Type, Lazy<ILocator>>();

    //        Services.Add(typeof(IService), CreateLazyProxy<ServiceA, ILocator>(new Lazy<ServiceA>()));
    //        Services.Add(typeof(ILogger), CreateLazyProxy<LoggerA, ILocator>(new Lazy<LoggerA>()));
    //    }

    //    // http://stackoverflow.com/questions/7310530/cast-generic-class-to-interface
    //    private static Lazy<TU> CreateLazyProxy<T, TU>(Lazy<T> input) where T : TU
    //    {
    //        return new Lazy<TU>(() => input.Value);
    //    }

    //    public static T Get<T>()
    //    {
    //        Lazy<ILocator> returnObject = Services[typeof(T)];
    //        return (T)returnObject.Value;
    //    }
    //}
}