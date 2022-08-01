using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorldOfTanksBlitz.Types.Tournaments.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StageState : byte
    {
        Draft,
        [EnumMember(Value = "groups_ready")]
        GroupsReady,
        [EnumMember(Value = "schedule_ready")]
        ScheduleReady,
        Complete
    }
}