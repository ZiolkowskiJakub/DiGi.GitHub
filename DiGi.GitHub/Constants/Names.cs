namespace DiGi.GitHub.Constants
{
    /// <summary>
    /// Provides a centralized collection of constant names used across the GitHub integration.
    /// </summary>
    public static class Names
    {
        /// <summary>
        /// Contains keys used for accessing GitHub configuration settings.
        /// </summary>
        public static class GitHubConfigurationFile
        {
            /// <summary>
            /// GitHub username.
            /// </summary>
            public const string Username = "USERNAME";

            /// <summary>
            /// GitHub email.
            /// </summary>
            public const string Email = "EMAIL";

            /// <summary>
            /// GitHub token.
            /// </summary>
            public const string Token = "TOKEN";

            /// <summary>
            /// GitHub Url.
            /// </summary>
            public const string Url = "URL";
        }

        /// <summary>
        /// Contains common Git branch name constants.
        /// </summary>
        public static class Branch
        {
            /// <summary>
            /// Main branch.
            /// </summary>
            public const string Main = "main";

            /// <summary>
            /// Master branch.
            /// </summary>
            public const string Master = "master";
        }

        /// <summary>
        /// Contains common Git remote name constants.
        /// </summary>
        public static class Remote
        {
            /// <summary>
            /// Origin remote.
            /// </summary>
            public const string Origin = "origin";
        }
    }
}