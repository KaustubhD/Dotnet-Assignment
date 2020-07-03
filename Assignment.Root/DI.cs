using System;
using Microsoft.Extensions.DependencyInjection;
using Assignment.Data;
using Assignment.Business;
using Assignment.Business.GraphQL.Types;
using Assignment.BUsiness.GraphQL.Queries;

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
            services.AddScoped<IHomeDetailRepository, HomeDetailRepository>();
            services.AddScoped<IHomeDetailService, HomeDetailService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddSingleton<IRestClientRepository, RestClientRepository>();
            services.AddScoped<AppQuery>();
            services.AddSingleton<LocationType>();
        }
    }
}
