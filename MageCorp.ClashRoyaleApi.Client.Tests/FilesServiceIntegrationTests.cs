namespace MageCorp.ClashRoyaleApi.Client.Tests;

public class FilesServiceIntegrationTests : IntegrationTestBase
{
    [Fact]
    public async Task GetFingerprintAsync_ShouldReturnFingerprint()
    {
        // Act
        var fingerprint = await _client.FilesService.GetFingerprintAsync();

        // Assert
        Assert.NotNull(fingerprint);
        Assert.NotNull(fingerprint.Sha);
    }
}
