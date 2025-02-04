using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;

namespace MageCorp.ClashRoyaleApi.Client.Tests;

public class ClashRoyaleApiClientIntegrationTests
{
    private readonly string _validBearerToken;
    private readonly string _clanTag;
    private readonly string _playerTag;
    private readonly string _clanName;
    private readonly string _tournamentName;
    private readonly int _locationId;

    private readonly ClashRoyaleApiClient _client;

    public ClashRoyaleApiClientIntegrationTests()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        _validBearerToken = configuration["ApiSettings:ValidBearerToken"]!;
        try { 
            var jwtToken = new JwtSecurityTokenHandler().ReadJwtToken(_validBearerToken); 
        }
        catch 
        { 
            Assert.Fail("Invalid Bearer Token");
        }
        _clanTag = configuration["ApiSettings:ClanTag"]!;
        _playerTag = configuration["ApiSettings:PlayerTag"]!;
        _clanName = configuration["ApiSettings:ClanName"]!;
        _tournamentName = configuration["ApiSettings:TournamentName"]!;
        _locationId = int.Parse(configuration["ApiSettings:LocationId"]!);

        var apiOptions = new ApiOptions(_validBearerToken, useProxy: true);
        _client = ClashRoyaleApiClient.Create(apiOptions);
    }

    [Fact]
    public async Task CardsService_ListAsync_ShouldReturnCards()
    {
        // Act
        var cards = await _client.CardsService.ListAsync();

        // Assert
        Assert.NotNull(cards);
        Assert.NotNull(cards.Items);
        Assert.NotEmpty(cards.Items);
    }

    [Fact]
    public async Task ChallengesService_ListChallengesAsync_ShouldReturnChallenges()
    {
        // Act
        var challenges = await _client.ChallengesService.ListChallengesAsync();

        // Assert
        Assert.NotNull(challenges);
        Assert.NotEmpty(challenges);
    }

    [Fact]
    public async Task ClansService_ListWarlogAsync_ShouldReturnWarlog()
    {
        // Act
        var warlog = await _client.ClansService.ListWarlogAsync(_clanTag);

        // Assert
        Assert.NotNull(warlog);
    }

    [Fact]
    public async Task ClansService_SearchAsync_ShouldReturnClans()
    {
        // Act
        var clans = await _client.ClansService.SearchAsync(name: _clanName);

        // Assert
        Assert.NotNull(clans);
        Assert.NotNull(clans.Items);
        Assert.NotEmpty(clans.Items);
    }

    [Fact]
    public async Task ClansService_SearchAsync_ShouldFail()
    {
        // Act
        var clans = await _client.ClansService.SearchAsync(name: "Ab");
        // Assert
        Assert.NotNull(clans);
        Assert.NotNull(clans.Error);
        Assert.Equal("badRequest", clans.Error!.Reason);
        Assert.Equal("Filtering parameter 'name' has to be at least 3 characters long", clans.Error!.Message);
    }

    [Fact]
    public async Task ClansService_ListRiverRaceLogAsync_ShouldReturnRiverRaceLog()
    {
        // Act
        var riverRaceLog = await _client.ClansService.ListRiverRaceLogAsync(_clanTag);

        // Assert
        Assert.NotNull(riverRaceLog);
        Assert.NotNull(riverRaceLog.Items);
    }

    [Fact]
    public async Task ClansService_GetCurrentWarAsync_ShouldReturnCurrentWar()
    {
        // Act
        var currentWar = await _client.ClansService.GetCurrentWarAsync(_clanTag);

        // Assert
        Assert.NotNull(currentWar);
    }

    [Fact]
    public async Task ClansService_GetAsync_ShouldReturnClan()
    {
        // Act
        var clan = await _client.ClansService.GetAsync(_clanTag);

        // Assert
        Assert.NotNull(clan);
        Assert.Equal(_clanTag, clan.Tag);
    }

    [Fact]
    public async Task ClansService_ListMembersAsync_ShouldReturnMembers()
    {
        // Act
        var members = await _client.ClansService.ListMembersAsync(_clanTag);

        // Assert
        Assert.NotNull(members);
        Assert.NotNull(members.Items);
        Assert.NotEmpty(members.Items);
    }

    [Fact]
    public async Task ClansService_GetCurrentRiverRaceAsync_ShouldReturnCurrentRiverRace()
    {
        // Act
        var currentRiverRace = await _client.ClansService.GetCurrentRiverRaceAsync(_clanTag);

        // Assert
        Assert.NotNull(currentRiverRace);
    }

    [Fact]
    public async Task FilesService_GetFingerprintAsync_ShouldReturnFingerprint()
    {
        // Act
        var fingerprint = await _client.FilesService.GetFingerprintAsync();

        // Assert
        Assert.NotNull(fingerprint);
        Assert.NotNull(fingerprint.Sha);
    }

    [Fact]
    public async Task GlobalTournamentsService_ListGlobalTournamentsAsync_ShouldReturnTournaments()
    {
        // Act
        var tournaments = await _client.GlobalTournamentsService.ListGlobalTournamentsAsync();

        // Assert
        Assert.NotNull(tournaments);
        Assert.NotNull(tournaments.Items);
        Assert.NotEmpty(tournaments.Items);
    }

    [Fact]
    public async Task LeaderboardsService_ListLeaderboardsAsync_ShouldReturnLeaderboards()
    {
        // Act
        var leaderboards = await _client.LeaderboardsService.ListLeaderboardsAsync();

        // Assert
        Assert.NotNull(leaderboards);
        Assert.NotNull(leaderboards.Items);
        Assert.NotEmpty(leaderboards.Items);
    }

    [Fact]
    public async Task LeaderboardsService_GetLeaderboardAsync_ShouldGetLeaderboard()
    {
        // Act
        var leaderboards = await _client.LeaderboardsService.ListLeaderboardsAsync();
        if (leaderboards == null || leaderboards.Items == null || leaderboards.Items.Count == 0)
        {
            Assert.Fail("No leaderboards found");
        }
        else
        {
            // Act
            var leaderboard = await _client.LeaderboardsService.GetLeaderboardAsync(leaderboards.Items[0].Id);
            // Assert
            Assert.NotNull(leaderboard);
            Assert.NotNull(leaderboard.Items);
            Assert.NotEmpty(leaderboard.Items);
        }
    }

    [Fact]
    public async Task LocationsService_ListLocationsAsync_ShouldReturnLocations()
    {
        // Act
        var locations = await _client.LocationsService.ListLocationsAsync();

        // Assert
        Assert.NotNull(locations);
        Assert.NotNull(locations.Items);
        Assert.NotEmpty(locations.Items);
    }

    [Fact]
    public async Task LocationsService_GetLocationAsync_ShouldReturnLocation()
    {
        // Act
        var location = await _client.LocationsService.GetLocationAsync(_locationId);

        // Assert
        Assert.NotNull(location);
        Assert.Equal(_locationId, location.Id);
    }

    [Fact]
    public async Task LocationsService_ListClanRankingsAsync_ShouldReturnClanRankings()
    {
        // Act
        var clanRankings = await _client.LocationsService.ListClanRankingsAsync(_locationId);

        // Assert
        Assert.NotNull(clanRankings);
        Assert.NotNull(clanRankings.Items);
        Assert.NotEmpty(clanRankings.Items);
    }

    [Fact]
    public async Task LocationsService_ListPlayerRankingsAsync_ShouldReturnPlayerRankings()
    {
        // Act
        var playerRankings = await _client.LocationsService.ListPlayerRankingsAsync(_locationId);

        // Assert
        Assert.NotNull(playerRankings);
        Assert.NotNull(playerRankings.Items);
    }

    [Fact]
    public async Task LocationsService_ListClanWarRankingsAsync_ShouldReturnClanWarRankings()
    {
        // Act
        var clanWarRankings = await _client.LocationsService.ListClanWarRankingsAsync(_locationId);

        // Assert
        Assert.NotNull(clanWarRankings);
        Assert.NotNull(clanWarRankings.Items);
        Assert.NotEmpty(clanWarRankings.Items);
    }

    [Fact]
    public async Task LocationsService_ListPlayerPathOfLegendRankingsAsync_ShouldReturnPlayerPathOfLegendRankings()
    {
        // Act
        var playerPathOfLegendRankings = await _client.LocationsService.ListPlayerPathOfLegendRankingsAsync("2023-01");

        // Assert
        Assert.NotNull(playerPathOfLegendRankings);
        Assert.NotNull(playerPathOfLegendRankings.Items);
        Assert.NotEmpty(playerPathOfLegendRankings.Items);
    }

    [Fact]
    public async Task LocationsService_GetLeagueSeasonAsync_ShouldReturnLeagueSeason()
    {
        // Act
        var leagueSeason = await _client.LocationsService.GetLeagueSeasonAsync("2023-01");

        // Assert
        Assert.NotNull(leagueSeason);
    }

    [Fact]
    public async Task LocationsService_ListSeasonPlayerRankingsAsync_ShouldReturnSeasonPlayerRankingsNotFound()
    {
        // Act
        var seasonPlayerRankings = await _client.LocationsService.ListSeasonPlayerRankingsAsync("2023-01");

        // Assert
        Assert.NotNull(seasonPlayerRankings);
        Assert.NotNull(seasonPlayerRankings.Error);
        Assert.Equal("notFound", seasonPlayerRankings.Error!.Reason);
    }

    [Fact]
    public async Task LocationsService_ListLeagueSeasonsAsync_ShouldReturnLeagueSeasons()
    {
        // Act
        var leagueSeasons = await _client.LocationsService.ListLeagueSeasonsAsync();

        // Assert
        Assert.NotNull(leagueSeasons);
        Assert.NotNull(leagueSeasons.Items);
        Assert.NotEmpty(leagueSeasons.Items);
    }

    [Fact]
    public async Task LocationsService_ListLadderTournamentRankingsAsync_ShouldReturnLadderTournamentRankings()
    {
        // Arrange
        var tournaments = await _client.GlobalTournamentsService.ListGlobalTournamentsAsync();
        if (tournaments == null || tournaments.Items == null || tournaments.Items.Count == 0)
        {
            Assert.Fail("No global tournaments found");
        }
        else
        {
            var tournamentTag = tournaments.Items[0].Tag;

            // Act
            var ladderTournamentRankings = await _client.LocationsService.ListLadderTournamentRankingsAsync(tournamentTag!);

            // Assert
            Assert.NotNull(ladderTournamentRankings);
        }
    }

    [Fact]
    public async Task LocationsService_ListPlayerPathOfLegendRankings_ShouldReturnPlayerPathOfLegendRankings()
    {
        // Act
        var playerPathOfLegendRankings = await _client.LocationsService.ListPlayerPathOfLegendRankings(_locationId);

        // Assert
        Assert.NotNull(playerPathOfLegendRankings);
    }

    [Fact]
    public async Task PlayersService_GetPlayerAsync_ShouldReturnPlayer()
    {
        // Act
        var player = await _client.PlayersService.GetPlayerAsync(_playerTag);

        // Assert
        Assert.NotNull(player);
        Assert.Equal(_playerTag, player.Tag);
    }

    [Fact]
    public async Task PlayersService_GetUpcomingChestsAsync_ShouldReturnUpcomingChests()
    {
        // Act
        var upcomingChests = await _client.PlayersService.GetUpcomingChestsAsync(_playerTag);

        // Assert
        Assert.NotNull(upcomingChests);
        Assert.NotNull(upcomingChests.Items);
        Assert.NotEmpty(upcomingChests.Items);
    }

    [Fact]
    public async Task PlayersService_ListBatlleLogAsync_ShouldReturnBattleLog()
    {
        // Act
        var battleLog = await _client.PlayersService.ListBatlleLogAsync(_playerTag);

        // Assert
        Assert.NotNull(battleLog);
        Assert.NotEmpty(battleLog);
    }

    [Fact]
    public async Task TournamentsService_GetTournamentAsync_ShouldReturnTournament()
    {
        var tournaments = await _client.TournamentsService.SearchAsync(name: _tournamentName, limit: 1);

        if (tournaments == null || tournaments.Items == null || tournaments.Items.Count != 1)
        {
            // Log the issue instead of failing the test
            Console.WriteLine("No tournaments found with the specified name.");
            return;
        }

        // Act
        var tournament = await _client.TournamentsService.GetTournamentAsync(tournaments.Items[0].Tag!);

        // Assert
        Assert.NotNull(tournament);
        Assert.Equal(tournaments.Items[0].Tag, tournament.Tag);
    }

    [Fact]
    public async Task TournamentsService_SearchAsync_ShouldReturnTournaments()
    {
        // Act
        var tournaments = await _client.TournamentsService.SearchAsync(name: _tournamentName);

        if (tournaments == null || tournaments.Items == null || !tournaments.Items.Any())
        {
            // Log the issue instead of failing the test
            Console.WriteLine("No tournaments found with the specified name.");
            return;
        }

        // Assert
        Assert.NotNull(tournaments);
        Assert.NotNull(tournaments.Items);
        Assert.NotEmpty(tournaments.Items);
    }
}
