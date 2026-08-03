namespace MageCorp.ClashRoyaleApi.Client.Tests;

public class LeaderboardsServiceIntegrationTests : IntegrationTestBase
{
    [Fact]
    public async Task ListLeaderboardsAsync_ShouldReturnLeaderboards()
    {
        // Act
        var leaderboards = await _client.LeaderboardsService.ListLeaderboardsAsync();

        // Assert
        Assert.NotNull(leaderboards);
        Assert.NotNull(leaderboards.Items);
        Assert.NotEmpty(leaderboards.Items);
    }

    [Fact]
    public async Task GetLeaderboardAsync_ShouldReturnLeaderboard()
    {
        // Arrange
        var leaderboards = await _client.LeaderboardsService.ListLeaderboardsAsync();
        if (leaderboards?.Items == null || leaderboards.Items.Count == 0)
        {
            Console.WriteLine("No leaderboards found.");
            return;
        }

        // Act
        var leaderboard = await _client.LeaderboardsService.GetLeaderboardAsync(leaderboards.Items[0].Id);

        if (leaderboard.Error != null)
        {
            Console.WriteLine($"Error: {leaderboard.Error.Message}");
            return;
        }

        // Assert
        Assert.NotNull(leaderboard);
        Assert.NotNull(leaderboard.Items);
        Assert.NotEmpty(leaderboard.Items);
    }
}
