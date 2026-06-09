using DiGi.GitHub.Classes;
using LibGit2Sharp;
using System.IO;

namespace DiGi.GitHub
{
    public static partial class Modify
    {
        /// <summary>
        /// Synchronizes a local directory with a GitHub repository by performing cloning if necessary, 
        /// pulling latest changes, committing local modifications, and pushing updates to the remote origin.
        /// </summary>
        /// <param name="gitHubConfigurationFile">The configuration object containing the repository URL and authentication credentials.</param>
        /// <param name="solutionDirectory">The local file system path where the repository is located or should be cloned.</param>
        /// <param name="branchName">The target branch name to synchronize. If specified, it manages synchronization between the current branch and the main branch.</param>
        /// <param name="commitMessage">An optional custom message for the commit of local changes. Defaults to "Auto-sync commit" if null.</param>
        /// <returns>True if the synchronization process was completed successfully; otherwise, false.</returns>
        public static bool Sync(this GitHubConfigurationFile? gitHubConfigurationFile, string? solutionDirectory, string? branchName, string? commitMessage = null)
        {
            if (string.IsNullOrWhiteSpace(solutionDirectory) || gitHubConfigurationFile?.Url is null || gitHubConfigurationFile?.Username is null || gitHubConfigurationFile?.Token is null)
            {
                return false;
            }

            if (!Directory.Exists(solutionDirectory))
            {
                return false;
            }

            if (!Repository.IsValid(solutionDirectory))
            {
                Repository.Clone(gitHubConfigurationFile.Url, solutionDirectory);
            }

            using Repository repository = new(solutionDirectory);

            if (repository.Info.IsHeadDetached)
            {
                return false;
            }

            string currentBranchName = repository.Head.FriendlyName;
            Branch currentBranch = repository.Branches[currentBranchName];
            if (currentBranch == null)
            {
                return false;
            }

            // Pull latest for current branch
            Commands.Checkout(repository, currentBranch);
            Pull(repository, gitHubConfigurationFile, currentBranchName);

            // Commit local changes on current branch
            Commands.Stage(repository, "*");
            if (repository.RetrieveStatus().IsDirty)
            {
                Signature? signature = Create.Signature(gitHubConfigurationFile);
                repository.Commit(commitMessage ?? "Auto-sync commit", signature, signature);
            }

            // Ensure remote exists
            Remote? remote = repository.Network.Remotes[Constants.Names.Remote.Origin];
            if (remote == null)
            {
                remote = repository.Network.Remotes.Add(Constants.Names.Remote.Origin, gitHubConfigurationFile.Url);
            }

            if (remote == null)
            {
                return false;
            }

            // Link and push the current branch
            repository.Branches.Update(currentBranch, b => b.Remote = remote.Name, b => b.UpstreamBranch = currentBranch.CanonicalName);
            repository.Network.Push(currentBranch, Create.PushOptions(gitHubConfigurationFile));

            Branch branch = currentBranch;

            // Only sync with master if we are creating a new branch
            if (string.IsNullOrWhiteSpace(branchName) || currentBranchName == branchName)
            {
                return true;
            }

            // Sync master with current branch
            Branch? masterBranch = repository.Branches[Constants.Names.Branch.Main];
            if (masterBranch is null)
            {
                //Master branch does not exists
                return false;
            }

            Commands.Checkout(repository, masterBranch);
            Pull(repository, gitHubConfigurationFile, masterBranch.FriendlyName);

            MergeResult mergeResult = repository.Merge(currentBranch, Create.Signature(gitHubConfigurationFile));
            if (mergeResult.Status == MergeStatus.Conflicts)
            {
                // Cannot push due to conflicts
                return false;
            }

            // Push updated master
            repository.Branches.Update(masterBranch, b => b.Remote = remote.Name, b => b.UpstreamBranch = masterBranch.CanonicalName);
            repository.Network.Push(masterBranch, Create.PushOptions(gitHubConfigurationFile));

            // Create new branch from updated master
            Commands.Checkout(repository, masterBranch);
            branch = repository.Branches[branchName] ?? repository.CreateBranch(branchName, masterBranch.Tip);
            Commands.Checkout(repository, branch);

            // Link and push new branch
            repository.Branches.Update(branch, b => b.Remote = remote.Name, b => b.UpstreamBranch = branch.CanonicalName);
            repository.Network.Push(branch, Create.PushOptions(gitHubConfigurationFile));

            return true;
        }
    }
}