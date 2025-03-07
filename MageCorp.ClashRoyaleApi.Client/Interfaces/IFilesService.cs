using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// </summary>
public interface IFilesService
{
    /// <summary>
    /// Get version fingerprint of game files.
    /// </summary>
    /// <returns></returns>
    Task<Fingerprint> GetFingerprintAsync();

    /// <summary>
    /// Get version fingerprint of game files.
    /// </summary>
    /// <returns></returns>
    Fingerprint GetFingerprint();
}
