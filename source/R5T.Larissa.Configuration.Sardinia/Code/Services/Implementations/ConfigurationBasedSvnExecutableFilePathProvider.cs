using System;

using Microsoft.Extensions.Options;using R5T.T0064;


namespace R5T.Larissa.Configuration
{[ServiceImplementationMarker]
    public class ConfigurationBasedSvnExecutableFilePathProvider : ISvnExecutableFilePathProvider,IServiceImplementation
    {
        private IOptions<SvnConfiguration> SvnConfiguration { get; }


        public ConfigurationBasedSvnExecutableFilePathProvider(IOptions<SvnConfiguration> svnConfiguration)
        {
            this.SvnConfiguration = svnConfiguration;
        }

        public string GetSvnExecutableFilePath()
        {
            var svnConfiguration = this.SvnConfiguration.Value;

            var svnExecutableFilePath = svnConfiguration.SvnExecutableFilePath;
            return svnExecutableFilePath;
        }
    }
}
