using Microsoft.Extensions.DependencyInjection;
using NorthwndWS.Business.Contracts;
using NorthwndWS.Business.Implementations;
using NorthwndWS.Business.Mapping.Automapper.Profiles;
using NorthwndWS.DataAccess.Contracts.Repositories;
using NorthwndWS.DataAccess.EF.Repositories;

namespace NorthwndWS.Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            // services --> builder.Services --> IoC Container / DI Container

            services.AddAutoMapper(typeof(CategoryProfile));

            // MANAGER REGISTRATIONS
            //---- Registrtaion İşlemi aşağıdaki gibi de yazılabiliyor : -----
            //services.Add(new ServiceDescriptor(
            //     typeof(ICategoryManager),
            //     typeof(CategoryManager),
            //     ServiceLifetime.Scoped));
            //----------------------------------------------------------------
                
            services.AddScoped<ICategoryManager, CategoryManager>();

            // REPOSITORY REGISTRATIONS
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
