using System;

using Microsoft.Extensions.Options;

using RawSvnConfiguration = R5T.Larissa.Configuration.Raw.SvnConfiguration;


namespace R5T.Larissa.Configuration
{
    public class SvnConfigurationConfigureOptions : IConfigureOptions<SvnConfiguration>
    {
        private IOptions<RawSvnConfiguration> RawSvnConfiguration { get; }


        public SvnConfigurationConfigureOptions(IOptions<RawSvnConfiguration> rawSvnConfiguration)
        {
            this.RawSvnConfiguration = rawSvnConfiguration;
        }

        public void Configure(SvnConfiguration options)
        {
            var rawSvnConfiguration = this.RawSvnConfiguration.Value;

            options.SvnExecutableFilePath = rawSvnConfiguration.SvnExecutableFilePath;
        }
    }
}
