using DiGi.Core.Classes;
using DiGi.GitHub.Classes;

namespace DiGi.GitHub
{
    public static partial class Create
    {
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