namespace MageCorp.ClashRoyaleApi.Client.Tests;

public class GlobalTournamentsServiceIntegrationTests : IntegrationTestBase
{
    [Fact]
    public async Task ListGlobalTournamentsAsync_ShouldReturnTournaments()
    {
        // Act
        var tournaments = await _client.GlobalTournamentsService.ListGlobalTournamentsAsync();

        // Assert
        Assert.NotNull(tournaments);
        Assert.NotNull(tournaments.Items);
    }
}
