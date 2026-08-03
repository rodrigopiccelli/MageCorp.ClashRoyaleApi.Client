namespace MageCorp.ClashRoyaleApi.Client.Tests;

public class LocationsServiceIntegrationTests : IntegrationTestBase
{
    [Fact]
    public async Task ListLocationsAsync_ShouldReturnLocations()
    {
        // Act
        var locations = await _client.LocationsService.ListLocationsAsync();

        // Assert
        Assert.NotNull(locations);
        Assert.NotNull(locations.Items);
        Assert.NotEmpty(locations.Items);
    }

    [Fact]
    public async Task GetLocationAsync_ShouldReturnLocation()
    {
        // Act
        var location = await _client.LocationsService.GetLocationAsync(_locationId);

        // Assert
        Assert.NotNull(location);
        Assert.Equal(_locationId, location.Id);
    }

    [Fact]
    public async Task ListClanRankingsAsync_ShouldReturnClanRankings()
    {
        // Act
        var clanRankings = await _client.LocationsService.ListClanRankingsAsync(_locationId);

        // Assert
        Assert.NotNull(clanRankings);
        Assert.NotNull(clanRankings.Items);
        Assert.NotEmpty(clanRankings.Items);
    }

    [Fact]
    public async Task ListPlayerRankingsAsync_ShouldReturnPlayerRankings()
    {
        // Act
        var playerRankings = await _client.LocationsService.ListPlayerRankingsAsync(_locationId);

        // Assert
        Assert.NotNull(playerRankings);
        Assert.NotNull(playerRankings.Items);
    }

    [Fact]
    public async Task ListClanWarRankingsAsync_ShouldReturnClanWarRankings()
    {
        // Act
        var clanWarRankings = await _client.LocationsService.ListClanWarRankingsAsync(_locationId);

        // Assert
        Assert.NotNull(clanWarRankings);
        Assert.NotNull(clanWarRankings.Items);
        Assert.NotEmpty(clanWarRankings.Items);
    }

    [Fact]
    public async Task ListPlayerPathOfLegendRankingsAsync_BySeasonId_ShouldReturnRankings()
    {
        // Act
        var rankings = await _client.LocationsService.ListPlayerPathOfLegendRankingsAsync("2023-01");

        // Assert
        Assert.NotNull(rankings);
        Assert.NotNull(rankings.Items);
        Assert.NotEmpty(rankings.Items);
    }

    [Fact]
    public async Task ListPlayerPathOfLegendRankingsAsync_ByLocationId_ShouldReturnRankings()
    {
        // Act
        var rankings = await _client.LocationsService.ListPlayerPathOfLegendRankingsAsync(_locationId);

        // Assert
        Assert.NotNull(rankings);
    }

    [Fact]
    public async Task GetLeagueSeasonAsync_ShouldReturnLeagueSeason()
    {
        // Act
        var leagueSeason = await _client.LocationsService.GetLeagueSeasonAsync("2023-01");

        // Assert
        Assert.NotNull(leagueSeason);
    }

    [Fact]
    public async Task ListSeasonPlayerRankingsAsync_ShouldReturnNotFound()
    {
        // Act
        var seasonPlayerRankings = await _client.LocationsService.ListSeasonPlayerRankingsAsync("2023-01");

        // Assert
        Assert.NotNull(seasonPlayerRankings);
        Assert.NotNull(seasonPlayerRankings.Error);
        Assert.Equal("notFound", seasonPlayerRankings.Error!.Reason);
    }

    [Fact]
    public async Task ListLeagueSeasonsAsync_ShouldReturnLeagueSeasons()
    {
        // Act
        var leagueSeasons = await _client.LocationsService.ListLeagueSeasonsAsync();

        // Assert
        Assert.NotNull(leagueSeasons);
        Assert.NotNull(leagueSeasons.Items);
        Assert.NotEmpty(leagueSeasons.Items);
    }

    [Fact]
    public async Task ListLeagueSeasonsV2Async_ShouldReturnLeagueSeasonsV2()
    {
        // Act
        var leagueSeasons = await _client.LocationsService.ListLeagueSeasonsV2Async();

        // Assert
        Assert.NotNull(leagueSeasons);
        Assert.NotNull(leagueSeasons.Items);
        Assert.NotEmpty(leagueSeasons.Items);
    }

    [Fact]
    public async Task ListLadderTournamentRankingsAsync_ShouldReturnRankings()
    {
        // Arrange
        var tournaments = await _client.GlobalTournamentsService.ListGlobalTournamentsAsync();
        if (tournaments?.Items == null || tournaments.Items.Count == 0)
        {
            Assert.Skip("No global tournaments available at the moment.");
            return;
        }

        // Act
        var rankings = await _client.LocationsService.ListLadderTournamentRankingsAsync(tournaments.Items[0].Tag!);

        // Assert
        Assert.NotNull(rankings);
    }
}
