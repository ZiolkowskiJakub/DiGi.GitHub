using DiGi.GitHub.Classes;
using LibGit2Sharp;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GitHub
{
    public static partial class Modify
    {
        public static bool Pull(Repository? repository, GitHubConfigurationFile? gitHubConfigurationFile)
        { 
            if(repository is null || gitHubConfigurationFile?.Username is null || gitHubConfigurationFile.Token is null || gitHubConfigurationFile.Email is null)
            {
                return false;
            }

            Remote remote = repository.Network.Remotes[Constans.Names.Remote.Origin];
            IEnumerable<string> specifications = remote.FetchRefSpecs.Select(x => x.Specification);
            Commands.Fetch(repository, remote.Name, specifications, Create.FetchOptions(gitHubConfigurationFile), null);

            Branch branch = repository.Branches[Constans.Names.Branch.Main];
            if(branch is null)
            {
                return false;
            }

            // Merge latest changes into current branch
            repository.Merge(branch, Create.Signature(gitHubConfigurationFile));
            return true;
        }
    }
}