using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
public enum ChallengeChainTypeEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "SINGLE_CHALLENGE")]
    SingleChallenge,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CHAIN_CHALLENGE")]
    ChainChallenge
}
