using DiGi.GitHub.Classes;
using LibGit2Sharp;

namespace DiGi.GitHub
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Signature"/> based on the provided GitHub configuration file.
        /// </summary>
        /// <param name="gitHubConfigurationFile">The GitHub configuration file containing the username and email.</param>
        /// <returns>A new <see cref="Signature"/> instance if both username and email are present; otherwise, null.</returns>
        public static Signature? Signature(this GitHubConfigurationFile? gitHubConfigurationFile)
        {
            string? username = gitHubConfigurationFile?.Username;
            if (username == null)
            {
                return null;
            }

            string? email = gitHubConfigurationFile!.Email;
            if (email == null)
            {
                return null;
            }

            return new Signature(username, email, System.DateTimeOffset.Now);
        }
    }
}