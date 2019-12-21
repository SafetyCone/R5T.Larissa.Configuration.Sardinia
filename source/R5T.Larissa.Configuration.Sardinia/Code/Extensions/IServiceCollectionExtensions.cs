using System;

using Microsoft.Extensions.DependencyInjection;

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
    }
}
