using System;

using Microsoft.Extensions.Options;


namespace R5T.Larissa.Configuration
{
    public class ConfigurationBasedSvnversionExecutableFilePathProvider : ISvnversionExecutableFilePathProvider
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
