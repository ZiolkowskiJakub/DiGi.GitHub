using DiGi.Core.Classes;
using DiGi.GitHub.Classes;

namespace DiGi.GitHub
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a GitHub configuration file by loading it from the specified path.
        /// </summary>
        /// <param name="path">The file system path to the configuration file.</param>
        /// <returns>A <see cref="GitHubConfigurationFile"/> object loaded with data, or null if the file does not exist or could not be loaded.</returns>
        public static GitHubConfigurationFile? GitHubConfigurationFile(string? path)
        {
            ConfigurationFile? configurationFile = Core.Create.ConfigurationFile(path);
            if (configurationFile is null)
            {
                return null;
            }

            return new GitHubConfigurationFile(configurationFile);
        }
    }
}