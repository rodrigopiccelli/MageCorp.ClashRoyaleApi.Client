namespace MageCorp.ClashRoyaleApi.Client.Tests;

public class CardsServiceIntegrationTests : IntegrationTestBase
{
    [Fact]
    public async Task ListAsync_ShouldReturnCards()
    {
        // Act
        var cards = await _client.CardsService.ListAsync();

        // Assert
        Assert.NotNull(cards);
        Assert.NotNull(cards.Items);
        Assert.NotEmpty(cards.Items);
    }

    [Fact]
    public async Task ListAsync_WithSupportItems_ShouldReturnSupportItems()
    {
        // Act
        var cards = await _client.CardsService.ListAsync();

        // Assert
        Assert.NotNull(cards);
        Assert.NotNull(cards.SupportItems);
    }
}
