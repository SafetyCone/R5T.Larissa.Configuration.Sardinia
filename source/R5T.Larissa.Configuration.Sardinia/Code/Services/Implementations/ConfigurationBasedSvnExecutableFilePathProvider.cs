using System;

using Microsoft.Extensions.Options;


namespace R5T.Larissa.Configuration
{
    public class ConfigurationBasedSvnExecutableFilePathProvider : ISvnExecutableFilePathProvider
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
