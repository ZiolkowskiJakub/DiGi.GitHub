using DiGi.GitHub.Classes;
using LibGit2Sharp;
using System;
using System.IO;

namespace DiGi.GitHub
{
    public static partial class Modify
    {
        public static void Sync(string[]? solutionDirectories, GitHubConfigurationFile? gitHubConfigurationFile)
        {
            if (solutionDirectories is null || gitHubConfigurationFile?.Url is null || gitHubConfigurationFile?.Username is null || gitHubConfigurationFile?.Token is null)
            {
                return;
            }

            foreach (string solutionDirectory in solutionDirectories)
            {
                if (solutionDirectory is null || !Directory.Exists(solutionDirectory))
                {
                    //Directory does not exists
                    continue;
                }

                if (!Repository.IsValid(solutionDirectory))
                {
                    // Clone if repo doesn't exist
                    Repository.Clone(gitHubConfigurationFile.Url, solutionDirectory);
                }

                using Repository repository = new(solutionDirectory);

                if (repository.Info.IsHeadDetached)
                {
                    continue;
                }

                string currentBranch = repository.Head.FriendlyName;

                // Determine main branch
                Branch mainBranch = repository.Branches[Constans.Names.Branch.Main];
                if (mainBranch == null)
                {
                    //Main branch does not found
                    continue;
                }

                // Checkout main/master and pull latest changes
                Commands.Checkout(repository, mainBranch);
                Pull(repository, gitHubConfigurationFile);

                // Create a new branch
                string branchName = $"auto-sync/{DateTime.Now:yyyyMMdd_HHmm}";
                Branch branch = repository.Branches[branchName] ?? repository.CreateBranch(branchName, mainBranch.Tip);
                Commands.Checkout(repository, branch);

                // Stage all changes
                Commands.Stage(repository, "*");

                // Commit if there are changes
                if (repository.RetrieveStatus().IsDirty)
                {
                    Signature? signature = Create.Signature(gitHubConfigurationFile);
                    repository.Commit($"Auto-sync commit on {branchName}", signature, signature);
                }
                else
                {
                    //No changes to commit
                }

                // Ensure remote exists
                Remote? remote = repository.Network.Remotes[Constans.Names.Remote.Origin];
                if (remote == null)
                {
                    //No 'origin' remote found. Adding one.
                    remote = repository.Network.Remotes.Add(Constans.Names.Remote.Origin, gitHubConfigurationFile.Url);
                }

                if (remote == null)
                {
                    //No 'origin' remote found
                    continue;
                }

                // Link local branch to remote upstream
                repository.Branches.Update(branch, b => b.Remote = remote.Name, b => b.UpstreamBranch = branch.CanonicalName);

                repository.Network.Push(branch, Create.PushOptions(gitHubConfigurationFile));

                //Pushed successfully
            }
        }
    }
}