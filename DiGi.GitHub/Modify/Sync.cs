using LibGit2Sharp;
using System;
using System.IO;

namespace DiGi.GitHub
{
    public static partial class Modify
    {
        public static void Sync(string[] solutionPaths, string githubUrl, string username, string token)
        {
            foreach (var path in solutionPaths)
            {
                if (!Directory.Exists(path))
                {
                    //Folder does not exist
                    continue;
                }

                //Syncing solution

                try
                {
                    // Clone if repo doesn't exist
                    if (!Repository.IsValid(path))
                    {
                        //Cloning repository
                        Repository.Clone(githubUrl, path);
                    }

                    using var repo = new Repository(path);

                    // Determine main branch
                    var masterBranch = repo.Branches["master"] ?? repo.Branches["main"];
                    if (masterBranch == null)
                    {
                        //No master/main branch found, skipping.
                        continue;
                    }

                    // Checkout master/main and pull latest changes
                    Commands.Checkout(repo, masterBranch);
                    Pull(repo, username, token);

                    // Create a new branch
                    string branchName = $"auto-sync/{DateTime.Now:yyyyMMdd_HHmm}";
                    var branch = repo.Branches[branchName] ?? repo.CreateBranch(branchName, masterBranch.Tip);
                    Commands.Checkout(repo, branch);

                    // Stage all changes
                    Commands.Stage(repo, "*");

                    // Commit changes if any
                    if (repo.RetrieveStatus().IsDirty)
                    {
                        var author = new Signature(username, $"{username}@example.com", DateTimeOffset.Now);
                        repo.Commit($"Auto-sync commit on {branchName}", author, author);
                        //Changes committed.
                    }
                    else
                    {
                        //No changes to commit.
                    }

                    // Push branch
                    var remote = repo.Network.Remotes["origin"];
                    var pushOptions = new PushOptions
                    {
                        CredentialsProvider = (_url, _user, _cred) =>
                            new UsernamePasswordCredentials { Username = username, Password = token }
                    };
                    repo.Network.Push(branch, pushOptions);
                    // Branch pushed successfully!
                }
                catch (Exception ex)
                {
                    //Error
                }
            }
        }
    }
}