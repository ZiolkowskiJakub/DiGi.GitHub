using DiGi.GitHub.Classes;
using LibGit2Sharp;

namespace DiGi.GitHub
{
    public static partial class Create
    {
        public static FetchOptions? FetchOptions(this GitHubConfigurationFile? gitHubConfigurationFile)
        {
            string? username = gitHubConfigurationFile?.Username;
            if(username == null)
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