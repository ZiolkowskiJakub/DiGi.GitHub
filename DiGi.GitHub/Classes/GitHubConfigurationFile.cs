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
                return GetValue<string>(Constans.Names.GitHubConfigurationFile.Email);
            }

            set
            {
                Add(Constans.Names.GitHubConfigurationFile.Email, value);
            }
        }

        [JsonIgnore]
        public string? Token
        {
            get
            {
                return GetValue<string>(Constans.Names.GitHubConfigurationFile.Token);
            }

            set
            {
                Add(Constans.Names.GitHubConfigurationFile.Token, value);
            }
        }

        [JsonIgnore]
        public string? Url
        {
            get
            {
                return GetValue<string>(Constans.Names.GitHubConfigurationFile.Url);
            }

            set
            {
                Add(Constans.Names.GitHubConfigurationFile.Url, value);
            }
        }

        [JsonIgnore]
        public string? Username
        {
            get
            {
                return GetValue<string>(Constans.Names.GitHubConfigurationFile.Username);
            }

            set
            {
                Add(Constans.Names.GitHubConfigurationFile.Username, value);
            }
        }
    }
}
