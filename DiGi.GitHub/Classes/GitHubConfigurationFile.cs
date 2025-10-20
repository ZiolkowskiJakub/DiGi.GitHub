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

        public GitHubConfigurationFile(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public GitHubConfigurationFile(GitHubConfigurationFile gitHubConfigurationFile)
            : base(gitHubConfigurationFile)
        {
        }

        [JsonIgnore]
        public string? Email
        {
            get
            {
                return GetValue<string>(Constans.Names.Email);
            }

            set
            {
                Add(Constans.Names.Email, value);
            }
        }

        [JsonIgnore]
        public string? Token
        {
            get
            {
                return GetValue<string>(Constans.Names.Token);
            }

            set
            {
                Add(Constans.Names.Token, value);
            }
        }

        [JsonIgnore]
        public string? Username
        {
            get
            {
                return GetValue<string>(Constans.Names.Username);
            }

            set
            {
                Add(Constans.Names.Username, value);
            }
        }
    }
}
