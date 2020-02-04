using System;
using System.Collections.Generic;
using System.Text;
using CoreMiddleware.Middleware.Interfaces;

namespace CoreMiddleware.Middleware
{
    public class RedisCacheMaintenance : IRedisCacheMaintenance
    {
        private readonly RedisCacheOptions _options;

        public RedisCacheMaintenance(RedisCacheOptions options)
        {
            _options = options;
        }

        public RedisCacheOptions Options => _options;

        public void DoSomethig()
        {
            //do something
        }
    }
}
