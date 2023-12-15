using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
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
