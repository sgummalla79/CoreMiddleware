using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using CoreMiddleware.Middleware.Interfaces;

namespace CoreMiddleware.Middleware
{
    public static class Extensions
    {
        public static void UseRedisCache(this IApplicationBuilder appBuilder)
        {
            appBuilder.UseMiddleware<RedisCacheMiddleware>();
        }

        public static IServiceCollection ConfigureRedisCache(this IServiceCollection services, Action<RedisCacheOptions> redisCacheSetupAction)
        {
            var redisCacheOptions = new RedisCacheOptions();

            redisCacheSetupAction.Invoke(redisCacheOptions);
            services.AddSingleton(factory => redisCacheOptions);
            services.AddSingleton<IRedisCacheMaintenance, RedisCacheMaintenance>();

            return services;
        }
    }
}