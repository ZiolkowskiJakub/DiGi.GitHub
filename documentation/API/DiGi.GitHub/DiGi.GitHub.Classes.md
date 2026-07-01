#### [DiGi\.GitHub](index.md 'index')

## DiGi\.GitHub\.Classes Namespace
### Classes

<a name='DiGi.GitHub.Classes.GitHubConfigurationFile'></a>

## GitHubConfigurationFile Class

Represents the configuration settings specifically for GitHub integration, extending the base configuration file functionality\.

```csharp
public class GitHubConfigurationFile : DiGi.Core.Classes.ConfigurationFile
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.ConfigurationFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.configurationfile 'DiGi\.Core\.Classes\.ConfigurationFile') → GitHubConfigurationFile
### Constructors

<a name='DiGi.GitHub.Classes.GitHubConfigurationFile.GitHubConfigurationFile()'></a>

## GitHubConfigurationFile\(\) Constructor

Initializes a new empty instance of the [GitHubConfigurationFile](DiGi.GitHub.Classes.md#DiGi.GitHub.Classes.GitHubConfigurationFile 'DiGi\.GitHub\.Classes\.GitHubConfigurationFile') class\.

```csharp
public GitHubConfigurationFile();
```

<a name='DiGi.GitHub.Classes.GitHubConfigurationFile.GitHubConfigurationFile(DiGi.Core.Classes.ConfigurationFile)'></a>

## GitHubConfigurationFile\(ConfigurationFile\) Constructor

Initializes a new instance of the [GitHubConfigurationFile](DiGi.GitHub.Classes.md#DiGi.GitHub.Classes.GitHubConfigurationFile 'DiGi\.GitHub\.Classes\.GitHubConfigurationFile') class by copying settings from another [DiGi\.Core\.Classes\.ConfigurationFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.configurationfile 'DiGi\.Core\.Classes\.ConfigurationFile')\.

```csharp
public GitHubConfigurationFile(DiGi.Core.Classes.ConfigurationFile? configurationFile);
```
#### Parameters

<a name='DiGi.GitHub.Classes.GitHubConfigurationFile.GitHubConfigurationFile(DiGi.Core.Classes.ConfigurationFile).configurationFile'></a>

`configurationFile` [DiGi\.Core\.Classes\.ConfigurationFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.configurationfile 'DiGi\.Core\.Classes\.ConfigurationFile')

The source configuration file to copy settings from\.

<a name='DiGi.GitHub.Classes.GitHubConfigurationFile.GitHubConfigurationFile(System.Text.Json.Nodes.JsonObject)'></a>

## GitHubConfigurationFile\(JsonObject\) Constructor

Initializes a new instance of the [GitHubConfigurationFile](DiGi.GitHub.Classes.md#DiGi.GitHub.Classes.GitHubConfigurationFile 'DiGi\.GitHub\.Classes\.GitHubConfigurationFile') class from a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public GitHubConfigurationFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GitHub.Classes.GitHubConfigurationFile.GitHubConfigurationFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the configuration settings\.
### Properties

<a name='DiGi.GitHub.Classes.GitHubConfigurationFile.Email'></a>

## GitHubConfigurationFile\.Email Property

Gets or sets the email address associated with the GitHub account\.

```csharp
public string? Email { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GitHub.Classes.GitHubConfigurationFile.Token'></a>

## GitHubConfigurationFile\.Token Property

Gets or sets the personal access token used for GitHub authentication\.

```csharp
public string? Token { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GitHub.Classes.GitHubConfigurationFile.Url'></a>

## GitHubConfigurationFile\.Url Property

Gets or sets the base URL for the GitHub API\.

```csharp
public string? Url { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GitHub.Classes.GitHubConfigurationFile.Username'></a>

## GitHubConfigurationFile\.Username Property

Gets or sets the username for the GitHub account\.

```csharp
public string? Username { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')