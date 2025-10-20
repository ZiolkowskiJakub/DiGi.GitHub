using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GitHub
{
    public static partial class Modify
    {
        public static void Pull(Repository? repository, string? username, string? token)
        {
            if(repository is null || username is null || token is null)
            {
                return;
            }

            Remote remote = repository.Network.Remotes["origin"];
            IEnumerable<string> refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);
            FetchOptions fetchOptions = new FetchOptions
            {
                CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials { Username = username, Password = token }
            };
            Commands.Fetch(repository, remote.Name, refSpecs, fetchOptions, null);

            Branch master = repository.Branches["master"] ?? repository.Branches["main"];
            if (master != null)
            {
                // Merge latest changes into current branch
                var merger = new Signature(username, $"{username}@example.com", DateTimeOffset.Now);
                repository.Merge(master, merger);
            }
        }
    }
}