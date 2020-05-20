using System;
using Microsoft.Extensions.DependencyInjection;
using Assignment.Data;
using Assignment.Business;

namespace Assignment.Root
{
    public class DI
    {
        public DI()
        {

        }
        public static void AddConfig(IServiceCollection services)
        {
            services.AddScoped<ITypeAheadLocationRepository, TypeAheadLocationRepository>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddSingleton<IRestClientRepository, RestClientRepository>();
        }
    }
}
