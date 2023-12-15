# MageCorp.ClashRoyaleApi.Client
Client library (C# wrapper) written in .NET 8.0 that provides an easy way to interact with the official  [Clash Royale API](https://developer.clashroyale.com) directly or through proxy

|                         | Stable                                                                                                                                  |
| ----------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
| Clash Royale API Client | [![NuGet](https://img.shields.io/nuget/v/MageCorp.ClashRoyaleApi.Client.svg)](https://www.nuget.org/packages/MageCorp.ClashRoyaleApi.Client/) |

## Supported Platforms
- .Net 7.0; .Net 8.0

## Features

- Dependency injection ready (can also be used standalone, see below)
- Supports async calls.

## Table of Contents

1. [Installation](#installation)
2. [Usage](#usage)
   - [Standalone Initialization](#standalone-initialization)
     - [Clash Royale Api](#clashroyaleapistandalone)
   - [Microsoft.Extensions.DependencyInjection Initialization](#di-initialization)
     - [Clash Royale Api](#clash-royale-api)
     - [Using Configuration](#using-configuration)
3. [License](#license)

## <a name="installation"></a> Installation

|                                       | Logo                                                                                                                                                                              | Stable                                                                                                                                  | 
| ------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- | 
| Clash Royale API Client               | <img src="https://raw.githubusercontent.com/rodrigopiccelli/MageCorp.ClashRoyaleApi.Client/master/icon.png" width="150" height="150" title="Github Logo"> | [![NuGet](https://img.shields.io/nuget/v/MageCorp.ClashRoyaleApi.Client.svg)](https://www.nuget.org/packages/MageCorp.ClashRoyaleApi.Client/) |

Following commands can be used to install MageCorp.ClashRoyaleApi.Client, run the following command in the Package Manager Console

```
NuGet\Install-Package MageCorp.ClashRoyaleApi.Client
```
Or use `dotnet cli`

```
dotnet add package MageCorp.ClashRoyaleApi.Client
```

## <a name="usage"></a> Usage

### <a name="standalone-initialization"></a> Standalone Initialization

If you do not want to use any DI framework, you have to instantiate `ClashRoyaleApiClient` as follows.

#### <a name="clashroyaleapistandalone"></a> ClashRoyaleApiClient Standalone Usage

```csharp
ApiOptions apiOptions = new("<your token>");
var clashRoyaleApiClient = ClashRoyaleApiClient.Create(apiOptions);
var playersService = clashRoyaleApiClient.PlayersService;
var clansService = clashRoyaleApiClient.ClansService;
```
`clashRoyaleApiClient` contains all necessary clients.

### <a name="di-initialization"></a> Microsoft.Extensions.DependencyInjection Initialization

First, you need to install `Microsoft.Extensions.DependencyInjection` NuGet package as follows

```
dotnet add package Microsoft.Extensions.DependencyInjection
```

#### <a name="clash-royale-api"></a> Clash Royale Api

Register necessary dependencies to `ServiceCollection` as follows

```csharp
var serviceProvider = new ServiceCollection()
    .AddClashRoyaleApiClient("<yor token>")
    .BuildServiceProvider();
```
Or
```csharp
var serviceProvider = new ServiceCollection()
    .AddClashRoyaleApiClient(new ApiOptions("<your token>"))
    .BuildServiceProvider();
```
Getting services:
```csharp
var cardsService = serviceProvider.GetRequiredService<ICardsService>();
var challengesService = serviceProvider.GetRequiredService<IChallengesService>();
var clansService = serviceProvider.GetRequiredService<IClansService>();
var globalTournamentsService = serviceProvider.GetRequiredService<IGlobalTournamentsService>();
var locationsService = serviceProvider.GetRequiredService<ILocationsService>();
var playersService = serviceProvider.GetRequiredService<IPlayersService>();
var tournamentsService = serviceProvider.GetRequiredService<ITournamentsService>();
```

#### <a name="using-configuration"></a> Using Configuration

There is an extension that supports `Microsoft.Extensions.Configuration` to store the `ApiOptions` configuration as follows

```json
{
  "ApiOptions": {
    "BearerToken": "<your token>",
    "ApiAddress": "https://api.clashroyale.com",
    "ApiVerstion": "v1",
    "UseProxy": false,
    "ProxyAddress": "https://proxy.royaleapi.dev"
  }
}
```

```csharp
string basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;
var configuration = new ConfigurationBuilder()
    .SetBasePath(basePath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables()
    .Build();
    
var serviceProvider = new ServiceCollection()
    .AddClashRoyaleApiClient(provider => {
        //you can use provider to get any required service needed to initialize your ApiOptions
        return configuration.GetApiOptionsSection("<sectionName>"); //if you don't specify the sectionName it will be "ApiOptions" by default
    })
    .BuildServiceProvider();
```



## <a name="license"></a> License

Licensed under MIT, see [LICENSE](LICENSE) for the full text.

