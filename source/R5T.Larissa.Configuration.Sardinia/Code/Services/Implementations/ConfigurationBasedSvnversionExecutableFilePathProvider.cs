using System;

using Microsoft.Extensions.Options;using R5T.T0064;


namespace R5T.Larissa.Configuration
{[ServiceImplementationMarker]
    public class ConfigurationBasedSvnversionExecutableFilePathProvider : ISvnversionExecutableFilePathProvider,IServiceImplementation
    {
        private IOptions<SvnConfiguration> SvnConfiguration { get; }


        public ConfigurationBasedSvnversionExecutableFilePathProvider(IOptions<SvnConfiguration> svnConfiguration)
        {
            this.SvnConfiguration = svnConfiguration;
        }

        public string GetSvnversionExecutableFilePath()
        {
            var svnConfiguration = this.SvnConfiguration.Value;

            var svnExecutableFilePath = svnConfiguration.SvnExecutableFilePath;
            return svnExecutableFilePath;
        }
    }
}
