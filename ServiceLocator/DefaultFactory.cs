using System;
using System.Collections.Generic;
using System.Linq;
using ServiceLocator.Interfaces;
using Tools;

namespace ServiceLocator
{
    public class DefaultFactory : IFactory
    {
        private readonly Configuration _config;

        public DefaultFactory(Configuration config)
        {
            _config = config;
        }

        #region IFactory Members

        public List<KeyValuePair<Type, Lazy<ILocator>>> Items
        {
            get { return _config.Items.Select(Build).ToList(); }
        }

        #endregion

        private KeyValuePair<Type, Lazy<ILocator>> Build(Type type)
        {
            var typeImpl = _config.Read(type);
            var impl = new Lazy<ILocator>(() => typeImpl.GetConstructor(Type.EmptyTypes).Invoke(null) as ILocator);
            var output = new KeyValuePair<Type, Lazy<ILocator>>(type, impl);

            return output;
        }
    }
}