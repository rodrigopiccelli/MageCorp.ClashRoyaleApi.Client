using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;

namespace MageCorp.ClashRoyaleApi.Client.Tests;

public abstract class IntegrationTestBase
{
    protected readonly string _clanTag;
    protected readonly string _playerTag;
    protected readonly string _clanName;
    protected readonly string _tournamentName;
    protected readonly int _locationId;

    protected readonly ClashRoyaleApiClient _client;

    protected IntegrationTestBase()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        var validBearerToken = configuration["ApiSettings:ValidBearerToken"]?.Trim();
        if (string.IsNullOrWhiteSpace(validBearerToken))
        {
            Assert.Skip("INTEGRATION_API_TOKEN is not set — skipping integration tests.");
        }

        try
        {
            new JwtSecurityTokenHandler().ReadJwtToken(validBearerToken);
        }
        catch
        {
            Assert.Skip("INTEGRATION_API_TOKEN is not a valid JWT — skipping integration tests.");
        }

        _clanTag = configuration["ApiSettings:ClanTag"]!;
        _playerTag = configuration["ApiSettings:PlayerTag"]!;
        _clanName = configuration["ApiSettings:ClanName"]!;
        _tournamentName = configuration["ApiSettings:TournamentName"]!;
        _locationId = int.Parse(configuration["ApiSettings:LocationId"]!);

        var clashRoyaleApiOptions = new ClashRoyaleApiOptions(validBearerToken!, useProxy: true);
        _client = ClashRoyaleApiClient.Create(clashRoyaleApiOptions);
    }
}
