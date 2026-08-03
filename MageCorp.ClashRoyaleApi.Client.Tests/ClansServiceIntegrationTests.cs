namespace MageCorp.ClashRoyaleApi.Client.Tests;

public class ClansServiceIntegrationTests : IntegrationTestBase
{
    [Fact]
    public async Task GetAsync_ShouldReturnClan()
    {
        // Act
        var clan = await _client.ClansService.GetAsync(_clanTag);

        // Assert
        Assert.NotNull(clan);
        Assert.Equal(_clanTag, clan.Tag);
    }

    [Fact]
    public async Task SearchAsync_ShouldReturnClans()
    {
        // Act
        var clans = await _client.ClansService.SearchAsync(name: _clanName);

        // Assert
        Assert.NotNull(clans);
        Assert.NotNull(clans.Items);
        Assert.NotEmpty(clans.Items);
    }

    [Fact]
    public async Task SearchAsync_WithShortName_ShouldReturnBadRequest()
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
    public async Task ListMembersAsync_ShouldReturnMembers()
    {
        // Act
        var members = await _client.ClansService.ListMembersAsync(_clanTag);

        // Assert
        Assert.NotNull(members);
        Assert.NotNull(members.Items);
        Assert.NotEmpty(members.Items);
    }

    [Fact]
    public async Task ListWarlogAsync_ShouldReturnWarlog()
    {
        // Act
        var warlog = await _client.ClansService.ListWarlogAsync(_clanTag);

        // Assert
        Assert.NotNull(warlog);
    }

    [Fact]
    public async Task ListRiverRaceLogAsync_ShouldReturnRiverRaceLog()
    {
        // Act
        var riverRaceLog = await _client.ClansService.ListRiverRaceLogAsync(_clanTag);

        // Assert
        Assert.NotNull(riverRaceLog);
        Assert.NotNull(riverRaceLog.Items);
    }

    [Fact]
    public async Task GetCurrentWarAsync_ShouldReturnCurrentWar()
    {
        // Act
        var currentWar = await _client.ClansService.GetCurrentWarAsync(_clanTag);

        // Assert
        Assert.NotNull(currentWar);
    }

    [Fact]
    public async Task GetCurrentRiverRaceAsync_ShouldReturnCurrentRiverRace()
    {
        // Act
        var currentRiverRace = await _client.ClansService.GetCurrentRiverRaceAsync(_clanTag);

        // Assert
        Assert.NotNull(currentRiverRace);
    }
}
