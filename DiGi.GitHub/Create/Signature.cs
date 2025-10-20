using DiGi.Core.Classes;
using DiGi.GitHub.Classes;
using LibGit2Sharp;

namespace DiGi.GitHub
{
    public static partial class Create
    {
        public static Signature? Signature(this GitHubConfigurationFile? gitHubConfigurationFile)
        {
            string? username = gitHubConfigurationFile?.Username;
            if(username == null)
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