using DiGi.GitHub.Classes;
using LibGit2Sharp;

namespace DiGi.GitHub
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="PushOptions"/> instance using the provided GitHub configuration file.
        /// </summary>
        /// <param name="gitHubConfigurationFile">The configuration file containing the GitHub username and token.</param>
        /// <returns>A <see cref="PushOptions"/> object if credentials are valid; otherwise, null.</returns>
        public static PushOptions? PushOptions(this GitHubConfigurationFile? gitHubConfigurationFile)
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

            return new PushOptions
            {
                CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials { Username = username, Password = token }
            };
        }
    }
}