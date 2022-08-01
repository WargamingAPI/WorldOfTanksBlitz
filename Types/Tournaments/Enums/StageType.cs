using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorldOfTanksBlitz.Types.Tournaments.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StageType : byte
    {
        [EnumMember(Value = "RR")]
        RoundRobin,
        [EnumMember(Value = "SE")]
        SingleElimination,
        [EnumMember(Value = "DE")]
        DoubleElimination
    }
}