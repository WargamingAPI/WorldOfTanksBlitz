using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WargamingApi.WorldOfTanksBlitz.Types.Clans.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClansRoles : byte
    {
        None = 0,

        [EnumMember(Value = "executive_officer")]
        ExecutiveOfficer,
        Private,
        Commander
    }
}