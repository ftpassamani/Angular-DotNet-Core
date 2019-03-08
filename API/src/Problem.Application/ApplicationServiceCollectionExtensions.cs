using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Problem.Application.Log;
using Problem.Utilities.Extensions.Collections;

namespace Problem.Application
{
    public static class ApplicationServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureProblemApplication(this IServiceCollection services)
        {
            // https://github.com/AutoMapper/AutoMapper.Extensions.Microsoft.DependencyInjection/issues/28#issuecomment-339772823
            services.AddAutoMapper(typeof(ApplicationServiceCollectionExtensions));

            services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetExecutingAssembly())
                .Where(c => c.Name.EndsWith("AppService"))
                .AsPublicImplementedInterfaces();

            services.AddTransient<ILogService, LogService>();

            return services;
        }
    }
}