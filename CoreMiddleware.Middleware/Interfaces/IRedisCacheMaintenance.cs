using System;
using System.Collections.Generic;
using System.Text;

namespace CoreMiddleware.Middleware.Interfaces
{
    public interface IRedisCacheMaintenance
    {
        RedisCacheOptions Options {get;}
        void DoSomethig();
    }
}
