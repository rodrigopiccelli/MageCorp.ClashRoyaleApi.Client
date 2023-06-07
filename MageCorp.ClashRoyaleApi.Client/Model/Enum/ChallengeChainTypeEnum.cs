using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum ChallengeChainTypeEnum
{
    [EnumMember(Value = "SINGLE_CHALLENGE")]
    SingleChallenge,
    [EnumMember(Value = "CHAIN_CHALLENGE")]
    ChainChallenge
}
