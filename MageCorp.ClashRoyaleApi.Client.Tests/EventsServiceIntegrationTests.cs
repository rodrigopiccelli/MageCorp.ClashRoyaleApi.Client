namespace MageCorp.ClashRoyaleApi.Client.Tests;

public class EventsServiceIntegrationTests : IntegrationTestBase
{
    [Fact]
    public async Task ListEventsAsync_ShouldReturnEvents()
    {
        // Act
        var events = await _client.EventsService.ListEventsAsync();

        // Assert
        Assert.NotNull(events);
    }
}
