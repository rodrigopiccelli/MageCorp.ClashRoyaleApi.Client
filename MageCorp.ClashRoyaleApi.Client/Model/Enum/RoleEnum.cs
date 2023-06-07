using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum RoleEnum
{
    [EnumMember(Value = "NOT_MEMBER")]
    NotMember,
    [EnumMember(Value = "MEMBER")]
    Member,
    [EnumMember(Value = "LEADER")]
    Leader,
    [EnumMember(Value = "ADMIN")]
    Admin,
    [EnumMember(Value = "COLEADER")]
    Coleader,
    [EnumMember(Value = "ELDER")]
    Elder
}
