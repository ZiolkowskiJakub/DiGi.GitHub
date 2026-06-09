using DiGi.GitHub.Classes;
using LibGit2Sharp;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GitHub
{
    public static partial class Modify
    {
        /// <summary>
        /// Pulls the latest changes from the remote origin for a specified branch and merges them into the current repository state.
        /// </summary>
        /// <param name="repository">The git repository to perform the pull operation on.</param>
        /// <param name="gitHubConfigurationFile">The configuration file containing GitHub authentication credentials such as username, token, and email.</param>
        /// <param name="branchName">The name of the branch to pull from. Defaults to the main branch defined in constants.</param>
        /// <returns>True if the fetch and merge operations were completed successfully; otherwise, false.</returns>
        public static bool Pull(Repository? repository, GitHubConfigurationFile? gitHubConfigurationFile, string branchName = Constants.Names.Branch.Main)
        {
            if (repository is null || gitHubConfigurationFile?.Username is null || gitHubConfigurationFile.Token is null || gitHubConfigurationFile.Email is null)
            {
                return false;
            }

            Remote remote = repository.Network.Remotes[Constants.Names.Remote.Origin];
            IEnumerable<string> specifications = remote.FetchRefSpecs.Select(x => x.Specification);
            Commands.Fetch(repository, remote.Name, specifications, Create.FetchOptions(gitHubConfigurationFile), null);

            Branch branch = repository.Branches[branchName];
            if (branch is null)
            {
                return false;
            }

            // Merge latest changes into current branch
            repository.Merge(branch, Create.Signature(gitHubConfigurationFile));
            return true;
        }
    }
}