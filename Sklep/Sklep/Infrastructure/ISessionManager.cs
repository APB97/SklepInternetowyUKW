using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.Infrastructure
{
    public interface ISessionManager
    {
        void Set<T>(string name, T value);
        T Get<T>(string key);
        T TryGet<T>(string key);
        void Abandon();
    }
}