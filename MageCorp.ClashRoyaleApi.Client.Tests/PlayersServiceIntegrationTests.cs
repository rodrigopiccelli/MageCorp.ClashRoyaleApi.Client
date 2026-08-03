namespace MageCorp.ClashRoyaleApi.Client.Tests;

public class PlayersServiceIntegrationTests : IntegrationTestBase
{
    [Fact]
    public async Task GetPlayerAsync_ShouldReturnPlayer()
    {
        // Act
        var player = await _client.PlayersService.GetPlayerAsync(_playerTag);

        // Assert
        Assert.NotNull(player);
        Assert.Equal(_playerTag, player.Tag);
    }

    [Fact]
    public async Task GetPlayerAsync_WithInvalidTag_ShouldReturnNotFound()
    {
        // Act
        var player = await _client.PlayersService.GetPlayerAsync("invalid");

        // Assert
        Assert.NotNull(player);
        Assert.NotNull(player.Error);
        Assert.Equal("notFound", player.Error!.Reason);
    }

    [Fact]
    public async Task GetUpcomingChestsAsync_ShouldReturnUpcomingChests()
    {
        // Act
        var upcomingChests = await _client.PlayersService.GetUpcomingChestsAsync(_playerTag);

        // Assert
        Assert.NotNull(upcomingChests);
        Assert.NotNull(upcomingChests.Items);
        Assert.NotEmpty(upcomingChests.Items);
    }

    [Fact]
    public async Task ListBatlleLogAsync_ShouldReturnBattleLog()
    {
        // Act
        var battleLog = await _client.PlayersService.ListBatlleLogAsync(_playerTag);

        // Assert
        Assert.NotNull(battleLog);
        Assert.NotEmpty(battleLog);
    }
}
