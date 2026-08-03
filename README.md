# <img src="https://raw.githubusercontent.com/rodrigopiccelli/MageCorp.ClashRoyaleApi.Client/master/icon.png" width="28" height="28" title="Package Logo"> MageCorp.ClashRoyaleApi.Client <a href="https://www.nuget.org/packages/MageCorp.ClashRoyaleApi.Client" align="right" target="_blank"><img alt="NuGet Version" src="https://img.shields.io/nuget/v/MageCorp.ClashRoyaleApi.Client?color=004880&style=for-the-badge" align="right" /></a>
Client library (C# wrapper) written in .NET (9.0 and 10.0) that provides an easy way to interact with the official [Clash Royale API](https://developer.clashroyale.com) directly or through proxy

## Supported Platforms
- .NET 9.0
- .NET 10.0

## Features

- Dependency injection ready (can also be used standalone, see below)
- Supports async calls.

## Table of Contents

1. [Installation](#installation)
2. [Usage](#usage)
   - [Standalone Initialization](#standalone-initialization)
     - [Clash Royale Api](#clashroyaleapistandalone)
   - [Microsoft.Extensions.DependencyInjection Initialization](#di-initialization)
     - [Using Configuration](#using-configuration)
3. [Integration Tests](#integration-tests)
   - [How to Configure](#integration-tests-configuration)
   - [How to Run](#integration-tests-run)
4. [License](#license)

## <a name="installation"></a> Installation

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

##### Using Default HttpClient

```csharp
ClashRoyaleApiOptions apiOptions = new("<your token>");
var clashRoyaleApiClient = ClashRoyaleApiClient.Create(apiOptions);
var playersService = clashRoyaleApiClient.PlayersService;
var clansService = clashRoyaleApiClient.ClansService;
```

##### Using Custom HttpClient

```csharp
ClashRoyaleApiOptions apiOptions = new("<your token>");
HttpClient httpClient = new HttpClient(new SocketsHttpHandler { // Custom configuration for HttpClient }); 
var clashRoyaleApiClient = ClashRoyaleApiClient.Create(apiOptions, httpClient);
var playersService = clashRoyaleApiClient.PlayersService;
var clansService = clashRoyaleApiClient.ClansService;
```

##### Using IHttpClientFactory

```csharp
ClashRoyaleApiOptions apiOptions = new("<your token>");
IServiceCollection services = new ServiceCollection();
services.AddHttpClient();
IServiceProvider serviceProvider = services.BuildServiceProvider();
IHttpClientFactory httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
var clashRoyaleApiClient = ClashRoyaleApiClient.Create(apiOptions, httpClientFactory);
var playersService = clashRoyaleApiClient.PlayersService;
var clansService = clashRoyaleApiClient.ClansService;
```


`clashRoyaleApiClient` contains all necessary clients.

## <a name="di-initialization"></a> Microsoft.Extensions.DependencyInjection Initialization

Register necessary dependencies to `ServiceCollection` as follows

```csharp
var serviceProvider = new ServiceCollection()
    .AddClashRoyaleApiClient("<your token>")
    .BuildServiceProvider();
```
Or
```csharp
var serviceProvider = new ServiceCollection()
    .AddClashRoyaleApiClient(new ClashRoyaleApiOptions("<your token>"))
    .BuildServiceProvider();
```
Or
```csharp
var serviceProvider = new ServiceCollection()
    .AddClashRoyaleApiClient(provider => {
        //you can use provider to get any required service needed to initialize your ClashRoyaleApiOptions
        return new ClashRoyaleApiOptions(...);
    })
    .BuildServiceProvider();
```
Getting services:
```csharp
var cardsService = serviceProvider.GetRequiredService<ICardsService>();
var clansService = serviceProvider.GetRequiredService<IClansService>();
var eventsService = serviceProvider.GetRequiredService<IEventsService>();
var globalTournamentsService = serviceProvider.GetRequiredService<IGlobalTournamentsService>();
var locationsService = serviceProvider.GetRequiredService<ILocationsService>();
var playersService = serviceProvider.GetRequiredService<IPlayersService>();
var tournamentsService = serviceProvider.GetRequiredService<ITournamentsService>();
var leaderboardsService = serviceProvider.GetRequiredService<ILeaderboardsService>();
var filesService = serviceProvider.GetRequiredService<IFilesService>();
```

#### <a name="using-configuration"></a> Using Configuration

There is an extension that supports `Microsoft.Extensions.Configuration` to store the `ClashRoyaleApiOptions` configuration as follows

```json
{
  "ClashRoyaleApiOptions": {
    "BearerToken": "<your token>",
    "ApiAddress": "https://api.clashroyale.com",
    "ApiVersion": "v1",
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

//if you don't specify the sectionName it will be "ClashRoyaleApiOptions" by default
var clashRoyaleApiOptions = configuration.GetClashRoyaleApiOptionsSection("<sectionName>");
    
var serviceProvider = new ServiceCollection()
    .AddClashRoyaleApiClient(clashRoyaleApiOptions)
    .BuildServiceProvider();
```




## <a name="integration-tests"></a> Integration Tests

Integration tests are organized by service, with one file per client (for example, `CardsServiceIntegrationTests`, `ClansServiceIntegrationTests`, and `LocationsServiceIntegrationTests`).

### <a name="integration-tests-configuration"></a> How to Configure

Tests load configuration from:

1. `appsettings.json`
2. `appsettings.local.json`
3. Environment variables

The `appsettings.local.json` file is intended for local secrets and should override placeholders from `appsettings.json`.

Use this structure:

```json
{
  "ApiSettings": {
    "ValidBearerToken": "YOUR_VALID_BEARER_TOKEN",
    "ClanTag": "#Y98VGGQY",
    "PlayerTag": "#UJQQLJQ9V",
    "ClanName": "Tenebrosos",
    "TournamentName": "clash",
    "LocationId": 57000038
  }
}
```

You can also use environment variables (double underscore for nested keys):

- `ApiSettings__ValidBearerToken`
- `ApiSettings__ClanTag`
- `ApiSettings__PlayerTag`
- `ApiSettings__ClanName`
- `ApiSettings__TournamentName`
- `ApiSettings__LocationId`

### <a name="integration-tests-run"></a> How to Run

Run all tests:

```powershell
dotnet test
```

Run only integration tests from one service file (example):

```powershell
dotnet test --filter "FullyQualifiedName~LocationsServiceIntegrationTests"
```


## <a name="license"></a> License

Licensed under MIT, see [LICENSE](LICENSE) for the full text.

