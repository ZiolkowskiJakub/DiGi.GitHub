using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GitHub.Classes
{
    public class GitHubConfigurationFile : ConfigurationFile
    {
        public GitHubConfigurationFile()
            : base()
        {
        }

        public GitHubConfigurationFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public GitHubConfigurationFile(ConfigurationFile? configurationFile)
            : base(configurationFile)
        {
        }

        [JsonIgnore]
        public string? Email
        {
            get
            {
                return GetValue<string>(Constants.Names.GitHubConfigurationFile.Email);
            }

            set
            {
                Add(Constants.Names.GitHubConfigurationFile.Email, value);
            }
        }

        [JsonIgnore]
        public string? Token
        {
            get
            {
                return GetValue<string>(Constants.Names.GitHubConfigurationFile.Token);
            }

            set
            {
                Add(Constants.Names.GitHubConfigurationFile.Token, value);
            }
        }

        [JsonIgnore]
        public string? Url
        {
            get
            {
                return GetValue<string>(Constants.Names.GitHubConfigurationFile.Url);
            }

            set
            {
                Add(Constants.Names.GitHubConfigurationFile.Url, value);
            }
        }

        [JsonIgnore]
        public string? Username
        {
            get
            {
                return GetValue<string>(Constants.Names.GitHubConfigurationFile.Username);
            }

            set
            {
                Add(Constants.Names.GitHubConfigurationFile.Username, value);
            }
        }
    }
}