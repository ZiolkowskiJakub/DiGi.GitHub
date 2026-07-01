#### [DiGi\.GitHub](index.md 'index')

## DiGi\.GitHub Namespace
### Classes

<a name='DiGi.GitHub.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.GitHub.Create.FetchOptions(thisDiGi.GitHub.Classes.GitHubConfigurationFile)'></a>

## Create\.FetchOptions\(this GitHubConfigurationFile\) Method

Creates a [FetchOptions\(this GitHubConfigurationFile\)](DiGi.GitHub.md#DiGi.GitHub.Create.FetchOptions(thisDiGi.GitHub.Classes.GitHubConfigurationFile) 'DiGi\.GitHub\.Create\.FetchOptions\(this DiGi\.GitHub\.Classes\.GitHubConfigurationFile\)') instance using the credentials provided in the GitHub configuration file\.

```csharp
public static FetchOptions? FetchOptions(this DiGi.GitHub.Classes.GitHubConfigurationFile? gitHubConfigurationFile);
```
#### Parameters

<a name='DiGi.GitHub.Create.FetchOptions(thisDiGi.GitHub.Classes.GitHubConfigurationFile).gitHubConfigurationFile'></a>

`gitHubConfigurationFile` [GitHubConfigurationFile](DiGi.GitHub.Classes.md#DiGi.GitHub.Classes.GitHubConfigurationFile 'DiGi\.GitHub\.Classes\.GitHubConfigurationFile')

The configuration file containing the username and token required for authentication\.

#### Returns
[LibGit2Sharp\.FetchOptions](https://learn.microsoft.com/en-us/dotnet/api/libgit2sharp.fetchoptions 'LibGit2Sharp\.FetchOptions')  
A [FetchOptions\(this GitHubConfigurationFile\)](DiGi.GitHub.md#DiGi.GitHub.Create.FetchOptions(thisDiGi.GitHub.Classes.GitHubConfigurationFile) 'DiGi\.GitHub\.Create\.FetchOptions\(this DiGi\.GitHub\.Classes\.GitHubConfigurationFile\)') object if valid credentials are found; otherwise, null\.

<a name='DiGi.GitHub.Create.GitHubConfigurationFile(string)'></a>

## Create\.GitHubConfigurationFile\(string\) Method

Creates a GitHub configuration file by loading it from the specified path\.

```csharp
public static DiGi.GitHub.Classes.GitHubConfigurationFile? GitHubConfigurationFile(string? path);
```
#### Parameters

<a name='DiGi.GitHub.Create.GitHubConfigurationFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the configuration file\.

#### Returns
[GitHubConfigurationFile](DiGi.GitHub.Classes.md#DiGi.GitHub.Classes.GitHubConfigurationFile 'DiGi\.GitHub\.Classes\.GitHubConfigurationFile')  
A [GitHubConfigurationFile\(string\)](DiGi.GitHub.md#DiGi.GitHub.Create.GitHubConfigurationFile(string) 'DiGi\.GitHub\.Create\.GitHubConfigurationFile\(string\)') object loaded with data, or null if the file does not exist or could not be loaded\.

<a name='DiGi.GitHub.Create.PushOptions(thisDiGi.GitHub.Classes.GitHubConfigurationFile)'></a>

## Create\.PushOptions\(this GitHubConfigurationFile\) Method

Creates a [PushOptions\(this GitHubConfigurationFile\)](DiGi.GitHub.md#DiGi.GitHub.Create.PushOptions(thisDiGi.GitHub.Classes.GitHubConfigurationFile) 'DiGi\.GitHub\.Create\.PushOptions\(this DiGi\.GitHub\.Classes\.GitHubConfigurationFile\)') instance using the provided GitHub configuration file\.

```csharp
public static PushOptions? PushOptions(this DiGi.GitHub.Classes.GitHubConfigurationFile? gitHubConfigurationFile);
```
#### Parameters

<a name='DiGi.GitHub.Create.PushOptions(thisDiGi.GitHub.Classes.GitHubConfigurationFile).gitHubConfigurationFile'></a>

`gitHubConfigurationFile` [GitHubConfigurationFile](DiGi.GitHub.Classes.md#DiGi.GitHub.Classes.GitHubConfigurationFile 'DiGi\.GitHub\.Classes\.GitHubConfigurationFile')

The configuration file containing the GitHub username and token\.

#### Returns
[LibGit2Sharp\.PushOptions](https://learn.microsoft.com/en-us/dotnet/api/libgit2sharp.pushoptions 'LibGit2Sharp\.PushOptions')  
A [PushOptions\(this GitHubConfigurationFile\)](DiGi.GitHub.md#DiGi.GitHub.Create.PushOptions(thisDiGi.GitHub.Classes.GitHubConfigurationFile) 'DiGi\.GitHub\.Create\.PushOptions\(this DiGi\.GitHub\.Classes\.GitHubConfigurationFile\)') object if credentials are valid; otherwise, null\.

<a name='DiGi.GitHub.Create.Signature(thisDiGi.GitHub.Classes.GitHubConfigurationFile)'></a>

## Create\.Signature\(this GitHubConfigurationFile\) Method

Creates a [Signature\(this GitHubConfigurationFile\)](DiGi.GitHub.md#DiGi.GitHub.Create.Signature(thisDiGi.GitHub.Classes.GitHubConfigurationFile) 'DiGi\.GitHub\.Create\.Signature\(this DiGi\.GitHub\.Classes\.GitHubConfigurationFile\)') based on the provided GitHub configuration file\.

```csharp
public static Signature? Signature(this DiGi.GitHub.Classes.GitHubConfigurationFile? gitHubConfigurationFile);
```
#### Parameters

<a name='DiGi.GitHub.Create.Signature(thisDiGi.GitHub.Classes.GitHubConfigurationFile).gitHubConfigurationFile'></a>

`gitHubConfigurationFile` [GitHubConfigurationFile](DiGi.GitHub.Classes.md#DiGi.GitHub.Classes.GitHubConfigurationFile 'DiGi\.GitHub\.Classes\.GitHubConfigurationFile')

The GitHub configuration file containing the username and email\.

#### Returns
[LibGit2Sharp\.Signature](https://learn.microsoft.com/en-us/dotnet/api/libgit2sharp.signature 'LibGit2Sharp\.Signature')  
A new [Signature\(this GitHubConfigurationFile\)](DiGi.GitHub.md#DiGi.GitHub.Create.Signature(thisDiGi.GitHub.Classes.GitHubConfigurationFile) 'DiGi\.GitHub\.Create\.Signature\(this DiGi\.GitHub\.Classes\.GitHubConfigurationFile\)') instance if both username and email are present; otherwise, null\.

<a name='DiGi.GitHub.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.GitHub.Modify.Pull(Repository,DiGi.GitHub.Classes.GitHubConfigurationFile,string)'></a>

## Modify\.Pull\(Repository, GitHubConfigurationFile, string\) Method

Pulls the latest changes from the remote origin for a specified branch and merges them into the current repository state\.

```csharp
public static bool Pull(Repository? repository, DiGi.GitHub.Classes.GitHubConfigurationFile? gitHubConfigurationFile, string branchName="main");
```
#### Parameters

<a name='DiGi.GitHub.Modify.Pull(Repository,DiGi.GitHub.Classes.GitHubConfigurationFile,string).repository'></a>

`repository` [LibGit2Sharp\.Repository](https://learn.microsoft.com/en-us/dotnet/api/libgit2sharp.repository 'LibGit2Sharp\.Repository')

The git repository to perform the pull operation on\.

<a name='DiGi.GitHub.Modify.Pull(Repository,DiGi.GitHub.Classes.GitHubConfigurationFile,string).gitHubConfigurationFile'></a>

`gitHubConfigurationFile` [GitHubConfigurationFile](DiGi.GitHub.Classes.md#DiGi.GitHub.Classes.GitHubConfigurationFile 'DiGi\.GitHub\.Classes\.GitHubConfigurationFile')

The configuration file containing GitHub authentication credentials such as username, token, and email\.

<a name='DiGi.GitHub.Modify.Pull(Repository,DiGi.GitHub.Classes.GitHubConfigurationFile,string).branchName'></a>

`branchName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the branch to pull from\. Defaults to the main branch defined in constants\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the fetch and merge operations were completed successfully; otherwise, false\.

<a name='DiGi.GitHub.Modify.Sync(thisDiGi.GitHub.Classes.GitHubConfigurationFile,string,string,string)'></a>

## Modify\.Sync\(this GitHubConfigurationFile, string, string, string\) Method

Synchronizes a local directory with a GitHub repository by performing cloning if necessary, 
pulling latest changes, committing local modifications, and pushing updates to the remote origin\.

```csharp
public static bool Sync(this DiGi.GitHub.Classes.GitHubConfigurationFile? gitHubConfigurationFile, string? solutionDirectory, string? branchName, string? commitMessage=null);
```
#### Parameters

<a name='DiGi.GitHub.Modify.Sync(thisDiGi.GitHub.Classes.GitHubConfigurationFile,string,string,string).gitHubConfigurationFile'></a>

`gitHubConfigurationFile` [GitHubConfigurationFile](DiGi.GitHub.Classes.md#DiGi.GitHub.Classes.GitHubConfigurationFile 'DiGi\.GitHub\.Classes\.GitHubConfigurationFile')

The configuration object containing the repository URL and authentication credentials\.

<a name='DiGi.GitHub.Modify.Sync(thisDiGi.GitHub.Classes.GitHubConfigurationFile,string,string,string).solutionDirectory'></a>

`solutionDirectory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The local file system path where the repository is located or should be cloned\.

<a name='DiGi.GitHub.Modify.Sync(thisDiGi.GitHub.Classes.GitHubConfigurationFile,string,string,string).branchName'></a>

`branchName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The target branch name to synchronize\. If specified, it manages synchronization between the current branch and the main branch\.

<a name='DiGi.GitHub.Modify.Sync(thisDiGi.GitHub.Classes.GitHubConfigurationFile,string,string,string).commitMessage'></a>

`commitMessage` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional custom message for the commit of local changes\. Defaults to "Auto\-sync commit" if null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the synchronization process was completed successfully; otherwise, false\.