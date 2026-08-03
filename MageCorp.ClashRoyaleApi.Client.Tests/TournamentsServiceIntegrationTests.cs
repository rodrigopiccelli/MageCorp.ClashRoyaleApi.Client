namespace MageCorp.ClashRoyaleApi.Client.Tests;

public class TournamentsServiceIntegrationTests : IntegrationTestBase
{
    [Fact]
    public async Task SearchAsync_ShouldReturnTournaments()
    {
        // Act
        var tournaments = await _client.TournamentsService.SearchAsync(name: _tournamentName);

        if (tournaments?.Items == null || !tournaments.Items.Any())
        {
            Console.WriteLine("No tournaments found with the specified name.");
            return;
        }

        // Assert
        Assert.NotNull(tournaments);
        Assert.NotNull(tournaments.Items);
        Assert.NotEmpty(tournaments.Items);
    }

    [Fact]
    public async Task GetTournamentAsync_ShouldReturnTournament()
    {
        // Arrange
        var tournaments = await _client.TournamentsService.SearchAsync(name: _tournamentName, limit: 1);

        if (tournaments?.Items == null || tournaments.Items.Count != 1)
        {
            Console.WriteLine("No tournaments found with the specified name.");
            return;
        }

        // Act
        var tournament = await _client.TournamentsService.GetTournamentAsync(tournaments.Items[0].Tag!);

        // Assert
        Assert.NotNull(tournament);
        Assert.Equal(tournaments.Items[0].Tag, tournament.Tag);
    }
}
