using DiGi.GitHub.Classes;
using LibGit2Sharp;

namespace DiGi.GitHub
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="FetchOptions"/> instance using the credentials provided in the GitHub configuration file.
        /// </summary>
        /// <param name="gitHubConfigurationFile">The configuration file containing the username and token required for authentication.</param>
        /// <returns>A <see cref="FetchOptions"/> object if valid credentials are found; otherwise, null.</returns>
        public static FetchOptions? FetchOptions(this GitHubConfigurationFile? gitHubConfigurationFile)
        {
            string? username = gitHubConfigurationFile?.Username;
            if (username == null)
            {
                return null;
            }

            string? token = gitHubConfigurationFile!.Token;
            if (token == null)
            {
                return null;
            }

            return new()
            {
                CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials { Username = username, Password = token }
            };
        }
    }
}