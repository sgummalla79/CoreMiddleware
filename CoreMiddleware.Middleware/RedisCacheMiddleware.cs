using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using CoreMiddleware.Middleware.Interfaces;

namespace CoreMiddleware.Middleware
{
    public class RedisCacheMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IRedisCacheMaintenance _redisCacheMaintenance;

        public RedisCacheMiddleware(RequestDelegate next, IRedisCacheMaintenance redisCacheMaintenance)
        {
            _next = next;
            _redisCacheMaintenance = redisCacheMaintenance;
        }

        public async Task Invoke(HttpContext context, IServiceScopeFactory scopeFactory)
        {
            await _next(context);
        }
    }
}
