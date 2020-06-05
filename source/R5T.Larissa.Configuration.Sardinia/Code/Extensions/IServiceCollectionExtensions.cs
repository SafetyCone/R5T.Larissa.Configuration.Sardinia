using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using R5T.Dacia;
using R5T.Sardinia;

using RawSvnConfiguration = R5T.Larissa.Configuration.Raw.SvnConfiguration;


namespace R5T.Larissa.Configuration.Sardinia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSvnConfiguration(this IServiceCollection services)
        {
            services
                .Configure<RawSvnConfiguration>()
                .ConfigureOptions<SvnConfigurationConfigureOptions>()
                ;

            return services;
        }

        public static IServiceAction<IOptions<SvnConfiguration>> AddSvnConfigurationAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IOptions<SvnConfiguration>>.New(() => services.AddSvnConfiguration());
            return serviceAction;
        }
    }
}
