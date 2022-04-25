using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorldOfTanksBlitz.Types.Tournaments.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status : byte
    {
        None,
        upcoming,
        registration_started,
        registration_finished,
        running,
        finished,
        complete,

        forming,
        confirmed,
        disqualified,
        [EnumMember(Value = "static")] Static
    }
}