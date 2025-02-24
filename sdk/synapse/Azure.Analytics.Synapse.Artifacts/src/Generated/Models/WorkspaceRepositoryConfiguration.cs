// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Git integration settings. </summary>
    public partial class WorkspaceRepositoryConfiguration
    {
        /// <summary> Initializes a new instance of WorkspaceRepositoryConfiguration. </summary>
        public WorkspaceRepositoryConfiguration()
        {
        }

        /// <summary> Initializes a new instance of WorkspaceRepositoryConfiguration. </summary>
        /// <param name="type"> Type of workspace repositoryID configuration. Example WorkspaceVSTSConfiguration, WorkspaceGitHubConfiguration. </param>
        /// <param name="hostName"> GitHub Enterprise host name. For example: https://github.mydomain.com. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="projectName"> VSTS project name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder to use in the repository. </param>
        internal WorkspaceRepositoryConfiguration(string type, string hostName, string accountName, string projectName, string repositoryName, string collaborationBranch, string rootFolder)
        {
            Type = type;
            HostName = hostName;
            AccountName = accountName;
            ProjectName = projectName;
            RepositoryName = repositoryName;
            CollaborationBranch = collaborationBranch;
            RootFolder = rootFolder;
        }

        /// <summary> Type of workspace repositoryID configuration. Example WorkspaceVSTSConfiguration, WorkspaceGitHubConfiguration. </summary>
        public string Type { get; set; }
        /// <summary> GitHub Enterprise host name. For example: https://github.mydomain.com. </summary>
        public string HostName { get; set; }
        /// <summary> Account name. </summary>
        public string AccountName { get; set; }
        /// <summary> VSTS project name. </summary>
        public string ProjectName { get; set; }
        /// <summary> Repository name. </summary>
        public string RepositoryName { get; set; }
        /// <summary> Collaboration branch. </summary>
        public string CollaborationBranch { get; set; }
        /// <summary> Root folder to use in the repository. </summary>
        public string RootFolder { get; set; }
    }
}
