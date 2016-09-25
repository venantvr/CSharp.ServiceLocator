using System;
using System.Collections.Generic;

namespace ServiceLocator.Interfaces
{
    public interface IFactory
    {
        List<KeyValuePair<Type, Lazy<ILocator>>> Items { get; }
    }
}