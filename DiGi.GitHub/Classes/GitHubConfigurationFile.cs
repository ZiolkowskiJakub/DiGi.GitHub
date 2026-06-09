using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GitHub.Classes
{
    /// <summary>
    /// Represents the configuration settings specifically for GitHub integration, extending the base configuration file functionality.
    /// </summary>
    public class GitHubConfigurationFile : ConfigurationFile
    {
        /// <summary>
        /// Initializes a new empty instance of the <see cref="GitHubConfigurationFile"/> class.
        /// </summary>
        public GitHubConfigurationFile()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubConfigurationFile"/> class from a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the configuration settings.</param>
        public GitHubConfigurationFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubConfigurationFile"/> class by copying settings from another <see cref="ConfigurationFile"/>.
        /// </summary>
        /// <param name="configurationFile">The source configuration file to copy settings from.</param>
        public GitHubConfigurationFile(ConfigurationFile? configurationFile)
            : base(configurationFile)
        {
        }

        /// <summary>
        /// Gets or sets the email address associated with the GitHub account.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the personal access token used for GitHub authentication.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the base URL for the GitHub API.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the username for the GitHub account.
        /// </summary>
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