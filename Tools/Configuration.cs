using System;
using System.Collections.Generic;

namespace Tools
{
    public class Configuration
    {
        // Fake xml configuration file
        private readonly Dictionary<Type, Type> _types = new Dictionary<Type, Type>
                                                         {
                                                             {
                                                                 Type.GetType("Business.ILogger"),
                                                                 Type.GetType("Business.LoggerA")
                                                             },
                                                             {
                                                                 Type.GetType("Business.IService"),
                                                                 Type.GetType("Business.ServiceA")
                                                             }
                                                         };

        public IEnumerable<Type> Items
        {
            get { return _types.Keys; }
            set { throw new NotImplementedException(); }
        }

        public Type Read(Type requestedType)
        {
            return _types.ContainsKey(requestedType) ? _types[requestedType] : null;
        }
    }
}